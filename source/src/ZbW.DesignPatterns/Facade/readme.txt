Problem:
Den Code muss man mit einer Vielzahl von Objekten arbeiten lassen, die zu einer hoch entwickelten Bibliothek oder einem Framework gehören. 
Normalerweise muss man alle diese Objekte initialisieren, Abhängigkeiten verfolgen, Methoden in der richtigen Reihenfolge ausführen usw.

Infolgedessen wird die Geschäftslogik der Klassen eng mit den Implementierungsdetails von Klassen von Drittanbietern verknüpft, was das Verständnis und die Wartung erschwert.

Lösung:
Eine Fassade ist eine Klasse, die eine einfache Schnittstelle zu einem komplexen Subsystem bietet, das viele bewegliche Teile enthält. 
Eine Fassade bietet möglicherweise eingeschränkte Funktionen im Vergleich zur direkten Arbeit mit dem Subsystem. 
Es enthält jedoch nur die Funktionen, die Kunden wirklich interessieren.

Eine Fassade ist praktisch, wenn Sie Ihre App in eine anspruchsvolle Bibliothek mit Dutzenden von Funktionen integrieren müssen, aber nur einen kleinen Teil ihrer Funktionalität benötigen

Was macht das Pattern:
