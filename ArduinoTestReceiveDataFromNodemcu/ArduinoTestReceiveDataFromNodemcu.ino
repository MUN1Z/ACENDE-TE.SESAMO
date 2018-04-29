void setup() {
  pinMode(8, INPUT);
  pinMode(LED_BUILTIN, OUTPUT);
}

void loop() {
  int val = digitalRead(8);     // read the input pin
  Serial.println(val);
  digitalWrite(LED_BUILTIN, val);    // sets the LED to the button's value
}

