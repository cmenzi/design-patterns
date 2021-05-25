# Iterator

## Problem

Bei einer Suche durch eine POS liste (grosse Collection von Daten) könnten viel LOC anfallen, was alles sehr unübersichtlich macht und die Datei z.B. muss immer geöffnet bleiben bis sie durchiteriert ist.

## Lösung

Mit dem Iterator-Pattern kann dies verhindert werden. Wie? Die Suchmethode sucht nicht mehr in der POS liste direkt, sondern im einzelnen Logeintrag und macht ein NEXT() falls nichts gefunden wurde. Der Iterator bereitet die Einträge vor und reicht sie weiter auf den Befehl NEXT.

## Was macht das Pattern

Wie oben beschrieben ist es eine Aufbereitung eines einzelnen Eintrags. Somit kann der Code vereinfacht werden. Man spricht beim Iterator auch von einem Cursor der auf die Einträge zeigt.

