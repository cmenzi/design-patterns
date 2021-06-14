Problem
Wie kann man Objekte vor direktem Zugriff schützen?

Lösung
Für das "reale" Objekt wird ein Stellvertreter definiert, welcher Erstellung und Zugriff auf dieses echte Objekt regelt.

Definition
Das Proxy-Pattern gehört zur Kategorie der Strukturmuster und überträgt die Steuerung eines Objektes
auf ein vorgelagertes Stellvertreterobjekt.

Ein Proxy ist eine Klasse, welche als Schnittstelle zu einem Objekt (bspw. Netzwerkverbindung, Datei, andere Ressource)
auftritt. Als Stellvertreter dieses Objekts regelt der Proxy die Erzeugung, Steuerung sowie den Zugriff auf dieses Objekt.
Wird das Objekt aufgerufen, erfolgt dies vorgelagert über das Proxy-Objekt.-

Verwendung:
- Passwortschutz: Vorgelagerte Proxy-Klasse, welche nur bei Eingabe von richtigem Passwort dahintergelagerte Methoden
(bspw. der Klasse "KONTO") aufrufen
- Trennung Objektinitialisierung und Objekterschaffung