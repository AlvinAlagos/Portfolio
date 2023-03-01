from typing import Tuple, Union
import RPi.GPIO as GPIO
import Freenove_DHT as DHT
import logging

from emails import EmailUser, Message, ReceiveEmail, SendEmail,ADMIN_ADDR,ADMIN_PASS,SMTP_PORT,SMTP_SERVER,IMAP_SERVER,IMAP_PORT
from timer import Timer

L = logging.getLogger()

TIMER = Timer()


Motor1A = 13 #a
Motor1B = 19 #b
Motor1E = 4 #enable


def get_temperature(pin: int) -> float:
    """Get the temperature from the DHT11 detector

    Args:
        pin (int): The RPi BCM pin connected to the DHT11

    Returns:
        float: The temperature detected by the DHT11
    """
    dht = DHT.DHT(pin)
    for _ in range(0, 15):
        chk = dht.readDHT11()
        if chk is dht.DHTLIB_OK:
            break
    ret = dht.temperature
    hum = dht.humidity
    L.info(f"Temperature: {ret}")
    L.info(f"Humidity: {hum}")
    return [ret,hum]


def try_send_email(
    to: str, toggle: Tuple[float, bool, bool], limits: Tuple[int, int] = (20, 10)
) -> bool:
    """Try sending an email based on given toggle

    Args:
        to (str): The email address of the receiver of the email
        toggle (Tuple[float, bool, bool]): The toggles for deciding if email should be sent. (Temperature, Fan Status, Should Resend)
        limits (Tuple[int, int], optional): The turn on/off temperatures. Defaults to (20, 10).

    Returns:
        bool: True if email is sent, otherwise, False
    """
    temperature, fan_on, should_resend = toggle
    high, low = limits
    decision = None
    if temperature > high and not fan_on and should_resend:
        decision = "open", "close"
    elif temperature < low and fan_on and should_resend:
        decision = "close", "open"

    if decision:
        y, n = decision
        message = Message(
            to, f"Should {y} fan?", f"Reply YES to {y} fan or NO to keep it {n}"
        )
        L.debug(f"{SMTP_SERVER} {SMTP_PORT}")
        send = SendEmail(SMTP_SERVER, SMTP_PORT, EmailUser(ADMIN_ADDR, ADMIN_PASS))
        send.send(message)
        return True

    return False


def try_receive_email(user_addr: str) -> str:
    """Try to receive an email from the APP

    Args:
        user_addr (str): Email of the User

    Returns:
        str: Fan status based on user decision - 'ON', 'OFF', 'KEEP', or None
    """
    receive = ReceiveEmail(IMAP_SERVER, IMAP_PORT, EmailUser(ADMIN_ADDR, ADMIN_PASS))
    for mail in receive.receive():
        L.info(mail)
        if mail.email.find(user_addr) != -1:
            content = mail.content.strip()
            if content.startswith("YES"):
                L.info("Replied YES")
                user_decision = mail.subject.find("open") != -1
                L.debug(user_decision)
                toggle_fan(user_decision) 
                if user_decision == True:
                    return "ON"
                else:
                    return "OFF"
                
            elif content == "NO":
                L.info("Replied NO")
                return "KEEP"
    return None

def toggle_fan(fan_on: bool):
    if (fan_on):
        print("Turning motor on")
        GPIO.output(Motor1A,GPIO.HIGH)
        GPIO.output(Motor1B,GPIO.LOW)
        GPIO.output(Motor1E,GPIO.HIGH)
    else:
        print("Stopping motor")
        GPIO.output(Motor1E,GPIO.LOW)
        L.debug("After OFF")
