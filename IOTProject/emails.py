from dataclasses import dataclass
from typing import Any, Tuple, List, Union
import logging

from email.message import EmailMessage
import email
import ssl

import smtplib
import imaplib

SMTP_SERVER = "192.168.0.11"
SMTP_PORT = 587
IMAP_SERVER = "192.168.0.11"
IMAP_PORT = 993

ADMIN_ADDR = "1946923@iotvanier.com"
ADMIN_PASS = "1946923"


L = logging.getLogger()


@dataclass
class EmailUser:
    address: str
    password: str


@dataclass
class Message:
    email: str
    subject: str
    content: str


class Email:
    def __init__(
        self,
        server: str,
        port: int,
        user: EmailUser,
        context=ssl.create_default_context(),
    ):
        self.server = server
        self.port = port
        self.user = user
        self.l = L


class SendEmail(Email):
    def connect(self) -> Union[smtplib.SMTP, None]:
        """Connect to an SMTP Server

        Returns:
            Union[smtplib.SMTP, None]: SMTP object if connection is successful, otherwise, None
        """
        server = None
        try:
            server = smtplib.SMTP(self.server, self.port)
            server.starttls()
            server.login(self.user.address, self.user.password)
            return server
        except Exception as e:
            self.l.warning(e)
            if server:
                server.quit()

    def send(self, message: Message) -> None:
        """Send an email

        Args:
            message (Message): Contains the destination, subject, and content of the email to be sent
        """
        server = self.connect()
        if server:
            msg = EmailMessage()
            msg["From"] = self.user.address
            msg["To"] = message.email
            msg["Subject"] = message.subject
            msg.set_content(message.content)

            server.send_message(msg)
            self.l.info("Email sent")
        else:
            self.l.warning("Did not connect to SMTP server")


class ReceiveEmail(Email):
    def connect(self) -> Union[imaplib.IMAP4_SSL, None]:
        """Connect to an IMAP Server

        Returns:
            Union[imaplib.IMAP4_SSL, None]: IMAP4_SSL object if connection is successful, otherwise, None
        """
        server = None
        try:
            server = imaplib.IMAP4_SSL(self.server, self.port)
            server.login(self.user.address, self.user.password)
            server.select()
            return server
        except Exception as e:
            self.l.warning(e)
            if server:
                server.close()

    def receive(self) -> List[Message]:
        """Receive emails

        Returns:
            List[Message]: List of unread emails in the IMAP inbox
        """
        server = self.connect()
        mails = []
        if server:
            status, data = server.search(None, "(UNSEEN)")
            if status != "OK":
                self.l.warning("Error in searching the IMAP mailbox")
            else:
                mail_ids = []
                for block in data:
                    mail_ids += block.split()
                responses = [server.fetch(mail_id, "(RFC822)") for mail_id in mail_ids]
                mails = self.parse_responses(responses)
            server.close()
        if mails:
            self.l.info("Emails received")
        else:
            self.l.info("Inbox empty")
        return mails

    def parse_responses(self, responses: List[Tuple[str, Any]]) -> List[Message]:
        """Parse the Server responses into Emails

        Args:
            responses (List[Tuple[str, Any]]): The list of response tuple from the IMAP Server

        Returns:
            List[Message]: The list of emails successfully parsed
        """
        mails = []
        for status, data in responses:
            if status == "OK":
                for response_part in data:
                    if isinstance(response_part, Tuple):
                        message = email.message_from_bytes(response_part[1])
                        content = ""
                        if message.is_multipart():
                            for part in message.get_payload():
                                if part.get_content_type() == "text/plain":
                                    content += part.get_payload()
                        else:
                            content = message.get_payload()
                        mail = Message(message["from"], message["subject"], content)
                        mails.append(mail)
        return mails
