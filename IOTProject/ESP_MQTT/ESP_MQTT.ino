#include <ESP8266WiFi.h>
#include <PubSubClient.h>
#include <SPI.h>
#include <MFRC522.h>

#define SS_PIN D8
#define RST_PIN D0

MFRC522 rfid(SS_PIN, RST_PIN);

MFRC522::MIFARE_Key key;

byte nuidPICC[4];

#define WIFI_SSID "TP-Link_2AD8"
#define WIFI_PASS "14730078"
#define MQTT_SERVER "192.168.0.103"

#define PHOTO_RESISTOR A0
int value; 

WiFiClient vanieriot;
PubSubClient client(vanieriot);

void setup_wifi(){
  delay(10);

  Serial.println();
  Serial.print("Connecting to ");
  Serial.println(WIFI_SSID);
  WiFi.begin(WIFI_SSID, WIFI_PASS);
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }
  Serial.println("");
  Serial.print("WiFi connected - ESP-8266 IP address: ");
  Serial.println(WiFi.localIP());
}

void callback(String topic, byte* message, unsigned int length) {
  Serial.print("Message arrived on topic: ");
  Serial.print(topic);
  Serial.print(". Message: ");
  String messagein;

  for (int i = 0; i < length; i++) {
    Serial.print((char)message[i]);
    messagein += (char)message[i];
  }
}

void reconnect() {
  while (!client.connected()) {
    Serial.print("Attempting MQTT connection...");
    if (client.connect("vanieriot")) {
      Serial.println("connected");

    } else {
      Serial.print("failed, rc=");
      Serial.print(client.state());
      Serial.println(" try again in 3 seconds");
      // Wait 5 seconds before retrying
      delay(1000);
    } 
  }
}

void setup() {
  Serial.begin(9600);
  setup_wifi();
  client.setServer(MQTT_SERVER, 1883);
  client.setCallback(callback);
  
 pinMode(PHOTO_RESISTOR, INPUT); // Set pResistor - A0 pin as an input (optional)
 delay(1000);
 setup_rfid();
}

void loop() {
  if (!client.connected()) {
    reconnect();
  }
  if(!client.loop()){
    client.connect("vanieriot");
  }
    
 value = analogRead(PHOTO_RESISTOR);
 Serial.println(value);
 client.publish("IoTlab/ESP",String(value).c_str());

 scan_rfid();

 delay(1500);
}

void setup_rfid() {
  Serial.begin(9600);
  SPI.begin();
  rfid.PCD_Init();
  Serial.println();
  Serial.print(F("Reader :"));
  rfid.PCD_DumpVersionToSerial();

  for (byte i = 0; i < 6; ++i) {
    key.keyByte[i] = 0xFF;
  }

  Serial.println();
  Serial.println(F("This code scan the MIFARE Classic NUID."));
  Serial.print(F("Using the following key: "));
  printHex(key.keyByte, MFRC522::MF_KEY_SIZE);
  Serial.println();
}

void scan_rfid() {
  if ( !rfid.PICC_IsNewCardPresent() ) return;
  
  if ( !rfid.PICC_ReadCardSerial() ) return;

  Serial.print(F("PICC type: "));
  MFRC522::PICC_Type piccType = rfid.PICC_GetType(rfid.uid.sak);
  Serial.println(rfid.PICC_GetTypeName(piccType));

  if (piccType != MFRC522::PICC_TYPE_MIFARE_MINI &&
      piccType != MFRC522::PICC_TYPE_MIFARE_1K &&
      piccType != MFRC522::PICC_TYPE_MIFARE_4K) {
    Serial.println(F("Your tag is not of type MIFARE Classic."));
  }

  if (rfid.uid.uidByte[0] != nuidPICC[0] ||
      rfid.uid.uidByte[1] != nuidPICC[1] ||
      rfid.uid.uidByte[2] != nuidPICC[2] ||
      rfid.uid.uidByte[3] != nuidPICC[3]) {
    Serial.println(F("A new card has been detected."));
    for (byte i = 0; i < 4; ++i) {
      nuidPICC[i] = rfid.uid.uidByte[i];    
    }
    Serial.println(F("The NUID tag is: "));
    Serial.print(F("In hex: "));
    printHex(rfid.uid.uidByte, rfid.uid.size);
    Serial.println();
    Serial.print(F("In dec: "));
    printDec(rfid.uid.uidByte, rfid.uid.size);
    Serial.println();
    String uid = uid_to_hexstr(rfid.uid.uidByte, rfid.uid.size);
    client.publish("IoTlab/RFID", uid.c_str());
  } else {
    rfid.PICC_HaltA();
    rfid.PCD_StopCrypto1();
  }
}

void printHex(byte *buffer, byte bufferSize) {
  for (byte i = 0; i < bufferSize; ++i) {
    Serial.print(buffer[i] < 0x10 ? " 0" : " ");
    Serial.print(buffer[i], HEX);
  }
}

void printDec(byte *buffer, byte bufferSize) {
  for (byte i = 0; i < bufferSize; ++i) {
    Serial.print(buffer[i] < 0x10 ? " 0" : " ");
    Serial.print(buffer[i], DEC);
  }
}

String uid_to_hexstr(byte *arr, size_t arr_size) {
  String ret = "";
  for (size_t i = 0; i < arr_size; ++i) {
    String tmp = String(arr[i], HEX);
    tmp.toUpperCase();
    ret += tmp;
  }
  return ret;
}
