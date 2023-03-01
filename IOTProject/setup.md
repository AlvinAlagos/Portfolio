# Setting up

_(Assuming you have python 3.9, used the class access point for the wifi, and installed + setup mosquitto)_

1. Run the command: `sudo apt install bluez bluez-tools pkg-config libboost-python-dev libboost-thread-dev libbluetooth-dev libglib2.0-dev python3-dev sqlite3` to install the apt dependencies
2. Extract the project zip file to a directory you want
3. Navigate to the project folder
4. Install the python libraries using the command: `cd pybluez-master && sudo pip install -e .[ble] && sudo pip install dash pandas dash-bootstrap-components dash_daq paho-mqtt`
5. Install the `ESP8266 module`, `PubSubClient` and `MFRC522` libraries for Arduino
6. Modify the variables in the following code to setup the app (Just find and search them using your IDE)
    - In `app.py`, change `DHT_PIN` to the GPIO pin for DHT11, `LEDRED` to the GPIO pin for the LED, `broker` to your IP
    - In `temperature.py`, change `Motor1A`, `Motor1B`, and `Motor1E` to the GPIO pins for IN1, IN2 and EN1 in the L293D
    - In `ESP_MQTT/ESP_MQTT.ino`, change `MQTT_SERVER` to your IP
7. To `create`, `read`, or `delete` users in the database, use dbmod.py by running: `python dbmod.py [command]` where command is the one of the three actions
8. Upload the `ESP_MQTT/ESP_MQTT.ino` file to the ESP8266
9. Run the app, `sudo python app.py`

_In case of trouble installing pybluez, the [docs](https://pybluez.readthedocs.io/en/latest/install.html) are here. Use the install from source since pypi does not have the updated source_ 
