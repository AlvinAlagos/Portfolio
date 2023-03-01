import logging
import sys
from datetime import datetime

from dash import Dash, dcc, html, Input, Output, no_update
import RPi.GPIO as GPIO
import dash_daq as daq
import dash_bootstrap_components as dbc
import random

import bluetooth
import bluetooth._bluetooth as bluez
from bluetooth_scan import bluetoothLowEnergyScan

from paho.mqtt import client as mqtt_client
import Freenove_DHT as DHT
from temperature import (
    get_temperature,
    try_receive_email,
    try_send_email,
    Motor1A,
    Motor1B,
    Motor1E,
)
from emails import (
    SMTP_SERVER, SMTP_PORT, IMAP_SERVER, IMAP_PORT, EmailUser, ADMIN_ADDR, ADMIN_PASS,
    Message, SendEmail
)
from timer import Timer
from database import UserPrefsDB

app = Dash(__name__, external_stylesheets=[dbc.themes.CYBORG])

L = logging.getLogger()

TIMER = Timer()
DHT_PIN = 26
LEDRED = 22

LIGHT_DATA = "0"
RFID_DATA = "0"

USER_ADDRESS = "0"
TEMP_THRESHOLD = 20
LIGHT_THRESHOLD = 160

THERMOMETER_FLAGS = ("NSENT", "OFF", "NDECLINE")
LIGHT_FLAG = "NSENT"

GPIO.setmode(GPIO.BCM)
GPIO.setwarnings(False)
GPIO.setup(LEDRED, GPIO.OUT)

#setting up DC motor
GPIO.setup(Motor1A,GPIO.OUT)
GPIO.setup(Motor1B,GPIO.OUT)
GPIO.setup(Motor1E,GPIO.OUT)
GPIO.output(Motor1A,GPIO.HIGH)
GPIO.output(Motor1B,GPIO.LOW)
GPIO.output(Motor1E,GPIO.LOW)

dash_theme = {
    "dark": True,
    "detail": "#007439",
    "primary": "#00EA64",
    "secondary": "#6E6E6E",
}

app.layout = html.Div(
    children=[
        daq.DarkThemeProvider(
            theme=dash_theme,
            children=[
                dcc.Interval(id="mqtt", interval=3*1000, n_intervals=0),
                html.H1(
                    "Dashboard",
                    className="h3 fw-bold row justify-content-center align-items-center",
                ),
                html.Div(
                    children = [
                        html.Div(
                            children= [
                        html.Div(
                            children = [
                            html.H5("User Info", id = "user-name", className= "text-center"),
                            html.Img(
                                            id="user-img",
                                            alt="User Image",
                                            src="https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460__340.png",
                                            className = "text-right",
                                            style={"max-width": "20%", "display": "block"}
                                        )
                            ],
                                className = "d-flex justify-content-between"
                            ),


                            html.H5("Light: 0 ", id="user-light", className= "text-left"),
                            html.H5("Temperature: 0 ", id="user-temperature", className= "text-left"),
                            
                            ],
                            className = "col-4 p-3 border rounded-start border-white ",
                            style = {"height": "260px"}),
                            html.Div(
                            children= [

                        html.Div(
                            children = [
                            html.H5("Bluetooth devices nearby: ",  style={"width": "50%", "float": "left"}),
                                html.H2(0, id="devices",style={"width": "50%","float": "right", "text-align": "right"}),
                                dbc.Button("Scan", id='bt-submit',className="me-1 btn btn-primary ml-2",color="Info", n_clicks=0, style={"float":"left"}),
                            ],
                                className = "d-flex justify-content-between"
                            ),

                            
                            ],
                            className = "col-4 p-3 border rounded-start border-white ",
                            style = {"height": "260px"}),
                            html.Div(
                            children= [

                        html.Div(
                            children = [
                            html.H5("Fan Status: "),
                                html.Img(id="fan-img",src=app.get_asset_url("fanout"), style={"display": "block", "width": "200px"}),
                            ],
                                # className = "d-flex justify-content-between"
                            ),

                            
                            ],
                            className = "col-4 p-3 border rounded-start border-white ",
                            style = {"height": "260px"}),
                            ],
                        
                    
                className="row "
                ),
                html.Div(
                    [
                        html.Div(
                            [
                                html.H2("Light Sensor", id="light-title", className="h5 text-center"),
                                html.Div(
                                    [
                                        html.Img(
                                            id="submit-val",
                                            alt="PUT IMAGE IN THIS ELEMENT AND CHANGE ALT ATTRIBUTE",
                                            src=app.get_asset_url("lightout"),
                                            style={"max-width": "100%", "display": "block", "margin-inline": "auto"}
                                        )
                                    ]
                                ),
                                dbc.Toast(
                                    [html.P("Email has been sent!")],
                                    id="light-toast",
                                    header="Light Sensor Alert",
                                    icon="warning",
                                    duration=3000,
                                    is_open=False,
                                    style={
                                        "position": "fixed",
                                        "top": 10,
                                        "right": 10,
                                        "width": 350,
                                    },
                                ),
                                dbc.Toast(
                                    [html.P("User Succesful Login!")],
                                    id="rfid-toast",
                                    header="Login Alert",
                                    icon="warning",
                                    duration=3000,
                                    is_open=False,
                                    style={
                                        "position": "fixed",
                                        "top": 10,
                                        "right": 10,
                                        "width": 350,
                                    },
                                ),
                            ],
                            className="col-4 p-3 border-top border-start border-bottom rounded-start border-white",
                        ),
                        html.Div(
                            [
                                html.H2(
                                    "Temperature and Humidity",
                                    className="row h5 justify-content-center align-items-center",
                                ),
                                html.Div(
                                    [
                                        html.Div(
                                            [
                                                daq.Thermometer(
                                                    id="my-thermometer-1",
                                                    value=10,
                                                    min=0,
                                                    max=50,
                                                    showCurrentValue=True,
                                                    units="°Celsius",
                                                )
                                            ],
                                            className="col-6",
                                        ),
                                        html.Div(
                                            [
                                                daq.Gauge(
                                                    id="my-gauge-1",
                                                    min=0,
                                                    max=100,
                                                    value=6,
                                                    showCurrentValue=True,
                                                    units="%Humidity",
                                                    style={"width": "fit-content"}
                                                ),
                                                dcc.Interval(
                                                    id="thermometer",
                                                    interval=5 * 1000,
                                                    n_intervals=0,
                                                )
                                            ],
                                            className="col-6",
                                        ),
                                    ],
                                    className="row justify-content-center align-items-center",
                                ),
                            ],
                            className="col-8 container-fluid p-3 border rounded-end border-white",
                        ),
                    ],
                    className="row",
                ),
            ],
        )
    ],
    className="container-fluid px-4 mt-3",
)

@app.callback(
    [Output(component_id="submit-val", component_property="src"),
    Output(component_id="light-toast", component_property="is_open"),
    Output(component_id="light-title", component_property="children")
    ],
    Input(component_id="mqtt", component_property="n_intervals")
)
def update_output_div(_):
    global LIGHT_DATA, LEDRED, LIGHT_THRESHOLD, LIGHT_FLAG
    asset, show_toast, value = app.get_asset_url("lightout"), False, f"Light Intensity: {LIGHT_DATA}"
    if USER_ADDRESS != '0':
        if int(LIGHT_DATA) < LIGHT_THRESHOLD:
            GPIO.output(LEDRED, GPIO.HIGH)  # Turn OFF LED
            if LIGHT_FLAG == "NSENT":
                message = Message(
                    USER_ADDRESS, "Light turned on!", f"The Light is ON at {datetime.now()}"
                )
                send = SendEmail(SMTP_SERVER, SMTP_PORT, EmailUser(ADMIN_ADDR, ADMIN_PASS))
                send.send(message)
                show_toast = True
            asset = app.get_asset_url("lighton")
            LIGHT_FLAG = "SENT"
        else:
            GPIO.output(LEDRED, GPIO.LOW)  # Turn OFF LED
            asset, show_toast = app.get_asset_url("lightout"), False
            LIGHT_FLAG = "NSENT"
    return asset, show_toast, value

@app.callback(
    [
        Output(component_id="user-img", component_property="src"),
        Output(component_id="user-name", component_property="children"),
        Output(component_id="user-temperature", component_property="children"),
        Output(component_id="user-light", component_property="children"),
        Output(component_id="rfid-toast", component_property="is_open")
    ],
    Input(component_id="mqtt", component_property="n_intervals")
)
def user_section(_):
    global RFID_DATA, USER_ADDRESS, TEMP_THRESHOLD, LIGHT_THRESHOLD, THERMOMETER_FLAGS, LIGHT_FLAG
    L.debug(RFID_DATA)
    if RFID_DATA != "0":
        db = UserPrefsDB("./iot.db")
        user_pref = db.fetch_single("SELECT * FROM user_prefs WHERE user_id = ?", (RFID_DATA,))
        USER_ADDRESS = user_pref.user_email
        TEMP_THRESHOLD, LIGHT_THRESHOLD = user_pref.temp_threshold, user_pref.light_intensity
        message = Message (
            user_pref.user_email, "User Enter!", f"User entered at {datetime.now()}"
        )
        send = SendEmail(SMTP_SERVER, SMTP_PORT, EmailUser(ADMIN_ADDR, ADMIN_PASS))
        send.send(message)
        RFID_DATA = "0"
        THERMOMETER_FLAGS = ("NSENT", "OFF", "NDECLINE")
        LIGHT_FLAG = "NSENT"
        GPIO.output(Motor1E,GPIO.LOW)
        return user_pref.user_image, f"User Info: {user_pref.user_name}", f"Temperature: {user_pref.temp_threshold}", f"Light: {user_pref.light_intensity}", True 
    return no_update, no_update, no_update, no_update, no_update


# Running this callback every 5 seconds
@app.callback(
    [
        Output(component_id="my-thermometer-1", component_property="value"),
        Output(component_id="my-gauge-1", component_property="value"),
        Output(component_id="fan-img", component_property="src")
    ],
    Input(component_id="thermometer", component_property="n_intervals")
)
def thermometer(_):
    global THERMOMETER_FLAGS
    temperature, humidity = get_temperature(DHT_PIN)

    # Flags for deciding if email should be sent, or not
    email_status, fan_status, decline = THERMOMETER_FLAGS

    # Flag for checking if email should be resent
    should_resend = decline != "DECLINE" or TIMER.is_second_elapsed(3600)

    fan_img = app.get_asset_url("fanon") if fan_status == "ON" else app.get_asset_url("fanout")

    if USER_ADDRESS != "0":
        # If email is not yet sent, Try to send an email
        if email_status == "NSENT":
            send_status = try_send_email(
                USER_ADDRESS, (temperature, fan_status == "ON", should_resend), (TEMP_THRESHOLD, TEMP_THRESHOLD)
            )

            # If an email is successfully sent, update the email_status flag
            if send_status:
                email_status = "SENT"

        # If an email is already sent, Try receiving the email
        else:
            receive_status = try_receive_email(USER_ADDRESS)
            # If the email is received successfully, update the email status flag
            if receive_status is not None:
                email_status = "NSENT"

                # If the user replied NO, Update the decline flag and reset the countdown for resending an email
                if receive_status == "KEEP":
                    decline = "DECLINE"
                    TIMER.reset_start_to_current()

                # If the user replied YES, Update the decline flag and set the fan_status to the user reply
                else:
                    decline = "NDECLINE"
                    fan_status = receive_status
                    FAN_IMG = app.get_asset_url("fanon") if receive_status == "ON" else app.get_asset_url("fanoff")
                    print(receive_status)

    # L.info(
        # f"Email Status: {email_status}, Fan Status: {fan_status}, Decline: {decline}"
    # )
    THERMOMETER_FLAGS = (email_status, fan_status, decline)
    return temperature, humidity, fan_img

@app.callback(
    Output(component_id="devices", component_property="children"),
    Input(component_id="bt-submit", component_property="n_clicks")
)
def bluetooth(_):
    return bluetoothLowEnergyScan()

broker = '10.0.0.33'
port = 1883
LIGHT_TOPIC = "IoTlab/ESP"
RFID_TOPIC = "IoTlab/RFID"
# generate client ID with pub prefix randomly
client_id = f'python-mqtt-{random.randint(0, 100)}'

def connect_mqtt() -> mqtt_client:
    def on_connect(client, userdata, flags, rc):
        if rc == 0:
            print("Connected to MQTT Broker!")
        else:
            print("Failed to connect, return code %d\n", rc)

    client = mqtt_client.Client(client_id)
    client.on_connect = on_connect
    client.connect(broker, port)
    return client


def subscribe(client: mqtt_client):
    def on_message(client, userdata, msg):
        global LIGHT_DATA, RFID_DATA
        if msg.topic == "IoTlab/ESP":
            LIGHT_DATA = msg.payload.decode()
        else:
            RFID_DATA = msg.payload.decode()
        
    client.subscribe(LIGHT_TOPIC)
    client.subscribe(RFID_TOPIC)
    client.on_message = on_message

def run():
    client = connect_mqtt()
    subscribe(client)
    client.loop_start()

if __name__ == "__main__":
    logging.basicConfig(
        format="[%(asctime)s] p%(process)s {%(pathname)s:%(lineno)d} %(levelname)s - %(message)s",
        level=logging.NOTSET,
    )

    if (
        ADMIN_ADDR == ""
        or ADMIN_PASS == ""
        or SMTP_SERVER == ""
        or IMAP_SERVER == ""
    ):
        L.fatal("Config not set! Check for missing constants!")
        sys.exit(-1)
    run()
    app.run_server(debug=True)
    GPIO.cleanup()
