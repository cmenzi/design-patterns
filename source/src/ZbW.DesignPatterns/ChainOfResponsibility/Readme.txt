Problem / Lösung
Alarmierung nach Einbruch

Pattern
IAlarm stellt den Methodenaufbau für jeden Alarmschritt bereit.
LightAlarm und PoliceAlarm stellen Stufen dar, die nacheinander durchlaufen werden (beliebig erweiterbar über das Interface)
Intruder löst die Ereigniskette aus
Alarm definiert die Logik für die Alarmschritte