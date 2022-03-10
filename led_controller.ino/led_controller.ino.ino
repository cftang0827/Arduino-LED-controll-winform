char incomeByte;
int delaySecond;
bool isBlink = false; // default is false
void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(LED_BUILTIN, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  if (Serial.available() > 0) {
    incomeByte = Serial.read();
    if (isDigit(incomeByte)) {
      delaySecond = ((int)incomeByte - 48) * 1000;
      isBlink = true;
      Serial.println("Start blinking");
    }else if (incomeByte == '#') {
      isBlink = false;
      Serial.println("Stop blinking");
    }
  }
  if (isBlink) {
    Serial.println(String(delaySecond / 1000));
    digitalWrite(LED_BUILTIN, HIGH);
    delay(delaySecond);
    digitalWrite(LED_BUILTIN, LOW);
    delay(delaySecond);
  }else {
    digitalWrite(LED_BUILTIN, LOW);
  }
}
