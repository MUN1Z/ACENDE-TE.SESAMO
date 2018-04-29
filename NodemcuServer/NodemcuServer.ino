#include <ESP8266WiFi.h>
#include <ESP8266WebServer.h>
#include <ArduinoJson.h>
#include <ESP8266mDNS.h>
#include <SoftwareSerial.h>

ESP8266WebServer server;

char* ssid = "MUNIZ";
char* password = "saosao2012";

void setup()
{
  pinMode(LED_BUILTIN, OUTPUT);     // Initialize the LED_BUILTIN pin as an output
  pinMode(15, INPUT);     // Initialize the LED_BUILTIN pin as an output
  
  WiFi.begin(ssid,password);
  Serial.begin(9600);
  
  if(WiFi.status() == WL_CONNECTED) //If WiFi connected to hot spot then start mDNS
  {
    if (MDNS.begin("esp8266")) {  //Start mDNS with name esp8266
      Serial.println("MDNS started");
    }
  }
  
  Serial.println("");
  Serial.print("IP Address: ");
  Serial.println(WiFi.localIP());

  server.on("/",[](){server.send(200, "text/plain", "Hello World!");});
  
  server.on("/led", ledController);
  server.begin();
}

void loop()
{
  server.handleClient();
}

void ledController()
{
  String data = server.arg("plain");
  StaticJsonBuffer<200> jBuffer;
  JsonObject& jObject = jBuffer.parseObject(data);
  String action = jObject["action"];
  
  if(action.toInt() == 1) 
    digitalWrite(LED_BUILTIN, HIGH);
  else 
    digitalWrite(LED_BUILTIN, LOW);
  
  server.send(204,"");
}
