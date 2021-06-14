# Flyweight

## Problem

Wie kann man grosse zusammengesetzte Objekte durch den Einsatz von elementaren Objekten, effizient beschreiben?

## Lösung

Definiere eine abstrakte und schmale Schnittstelle, dass durch das konkrete leichtgewichtige Objekt und vom normalen Objekt implementiert wird. Eine Factory erzeugt und verwaltet alle Flyweights. Somit werden nur die notwendigen Objekte bei Bedarf erzeugt.



![Example Flyweight](https://dotnettrickscloud.blob.core.windows.net/img/designpatterns/flyweight1.png)