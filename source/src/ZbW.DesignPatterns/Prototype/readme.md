# Prototype
Beim erstellen eines Prototpyen ist es das Ziel eine
Kopie des Objektes zu erzeugen ohne dieses sleber mit 
viel Aufwand selber zu erzeugen. Man unterschiedet bei der
Implementierung an `ShallowCopy()` und `DeepCopy()`.

## ShallowCopy():
Bei dieser Variante wird nicht "komplette" kopie erzeugt.
Bei allen TypeValue Variablen wird eine kopie abgelegt, bei den
RefencType Variablen wird nur die Referent mit kopiert. Dies ist
in gewissen fällen erwünscht weil es sehr performanit ist.

| Variable				 | Methode |
| ---------------------- |:-------:|
| int Zahl = 10;		 | kopie   |
| string Name = "Marc";  | kopie   |
| Object Person = {....} | Referenz zum Original Object   |

## DeepCopy():
Beim DeepCopy werden die ValueType so wie auch die Referenz Type
Variablen kopiert. Somit kann man auch bei CopyObject Änderungen/Anpassungen
druchführen ohne das das dies das Original-Obejct beinflusst. 

| Variable				 | Methode |
| ---------------------- |:-------:|
| int Zahl = 10;		 | kopie   |
| string Name = "Marc";  | kopie   |
| Object Person = {....} | (kopie) neues Object mit neuer Referenz  |

![alt text](http://www.csharp411.com/wp-content/uploads/2008/05/objectclone.jpg "ShallowCopy() / DeepCopy()")

### Zusatz ICloneable
Das Interface ICloneable wurd grundsätzlich nicht empfohlen,
weil hinter der Implementierung nicht klar ist welche Implementierung
genau gemacht wurde. `ShallowCopy()` und `DeepCopy()`.

