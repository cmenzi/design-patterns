Das Proxy-Pattern gehört zur Kategorie der Strukturmuster und überträgt die Steuerung eines Objektes
auf ein vorgelagertes Stellvertreterobjekt.

Ein Proxy ist eine Klasse, welche als Schnittstelle zu einem Subjekt (bspw. Netzwerkverbindung, Datei, andere Ressource)
auftritt. Als Stellvertreter dieses Subjekts regelt der Proxy die Erzeugung sowie Steuerung dieses Subjekts und
gibt dieses Subjekt nach Erzeugung weiter.

Verwendung:
- Passwortschutz: Vorgelagerte Proxy-Klasse, welche nur bei Eingabe von richtigem Passwort dahintergelagerte Methoden
(bspw. der Klasse "KONTO") aufrufen
- Trennung Objektinitialisierung und Objekterschaffung