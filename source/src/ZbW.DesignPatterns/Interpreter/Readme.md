# Interpreter

## Problem

Das Interpretermuster definiert eine Repräsentation für die Grammatik einer Sprache und die Möglichkeit, Sätze dieser Sprache zu interpretieren.
Z.B. Römische Zahlen, Datum etc.

## Lösung

Ein Interface 'AbstractExpression' schreibt eine Methode 'Evaluate()' vor, die von allen abgeleiteten, konkreten Klassen implementiert werden muss und die entsprechende Expression auswertet.
Für den zu interpretierenden Satz wird gemäss der Grammatik ein Syntaxbaum aus Nichtterminal- und Terminalausdrücken aufgebaut. Dies kann durch einen externen Parser oder den Client selbst geschehen. 

## Was macht das Pattern

Interpretiert die Anweisungen in einer Sprachgrammatik oder in Notationen.
Dieses Pattern beinhaltet die Implementierung einer Ausdrucksschnittstelle, die angibt, einen bestimmten Kontext zu interpretieren.