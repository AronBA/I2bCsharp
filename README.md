# I2bCsharp

```c#
Kontrollfragen


Frage 1:
C# läuft?

	A) mit Java
	X B) mit dem .NET-Framework von Microsoft
	C) nur auf Linux


Frage 2:
Das .NET-Framework

Welcher Teil läuft nicht mit dem .NET-Framework?
	X A) Betriebssystem
	B) .NET Framework Class Library
	C) Common Language Runtime

Frage 3:
Variablennamen

Welches ist keine C# Variablen-Name?

	X A) 1Star
	B) Bad_Var
	x C) #PersonName#

Frage 4:
Mein erstes C# Programm

Wie heisst die IDE, mit der man C#-Programme erstellt?

	A) CStudio
	B) 3D Studio Max
	X C) Visual Studio
	D) Visual Maya

Frage 5:
Mein erstes C# Programm

Jede Konsolenanwendung in C# sollte enthalten:

	X A) Main method
	B) Variablen
	C) Input-output

Frage 6:
Mein erstes C# Programm

Welche Art von Anwendung verwendet eine reine Textschnittstelle?
	X A) Console Application
	B) Mobile Application
	C) Windows Application

Frage 7: 
Ausgabe anzeigen

Vervollständigen Sie die Codezeile mit dem Text "Ich lerne C#":

Console.WriteLine("string");


Frage 8: 
Schreiben Sie ein Programm, um "Wissen ist Macht." zu drucken. Vergessen Sie nicht, am Ende des Zitats ein Satzzeichen zu setzen.

Es können sowohl die Methoden Console.Write als auch Console. WriteLine verwendet werden.

using System;

namespace I2bCsharp
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Wissen ist Macht.");
        }
            
    }
}

Frage 9:
Was ist die Ausgabe dieses Codes?

int a = 4; 
int b = 2; 
Console.Write(a); 
Console.Write(b);

	A) 4
	X B) 42
	C) 24
	D) 2
  
  

Frage 10:
Vervollständigen Sie die folgende Codezeile:

string temp;
temp = Console.ReadLine();



Frage 11:

Sie erstellen ein Berechtigungsprogramm für Ihre Anwendung.
Der gegebene Code nimmt den Namen der Person als Eingabe und gibt ihn im gegebenen Format aus.
Vervollständigen Sie das Programm so, dass es auch das Alter als Eingabe nimmt und den entsprechenden Text im vorgegebenen Format ausgibt.

Beispiel-Eingabe
Tom
26

Beispiel Ausgabe
Name: Tom
Alter: 26

Hinweis
Die Methode Console.ReadLine() gibt nur einen String zurück. Sie müssen das Alter in eine Ganzzahl umwandeln.

using System;

namespace I2bCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben sie ihren Namen an: ");
            string name = Console.ReadLine();
            Console.WriteLine("Geben sie ihr Alter an");
            int alter =  Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Alter: " + alter);
        }

    }
}

Frage 12:
Benutzereingabe

Vervollständigen Sie die folgende Codezeile:

double n; 
string x = "77";
n = Convert.ToDouble(x);


Frage 13:
Kommentare

Was ist die Ausgabe dieses Codes?

int x = 8; 
// x = 3; 
Console.WriteLine(x);

8


Frage 14:
Das Schlüsselwort var

Was ist der Typ der Variable temp?
var temp = 14.55;

	A) String
	B) Double
	X C) Integer
	D) Boolean


Frage 15:
Das Schlüsselwort var

Was ist die Ausgabe dieses Codes?
var n1;
n1 = true;
Console.WriteLine(n1);

es gibt einen fehler

Frage 16:
Konstanten

Füllen Sie das Leerzeichen aus, um die Variable num zu einer Konstanten zu machen.

const int num = 2;


Frage 17:
Arithmetische Operatoren

Sie müssen einen Parkettboden für Ihr rechteckiges Wohnzimmer kaufen.
Schreiben Sie ein Programm, das die Länge und Breite des Raums als Eingabe nimmt und die Fläche des Raums (in Quadratmetern) berechnet.
Die Variablen für Länge und Breite sind bereits definiert.

Beispiel-Eingabe:
5.4
2.3

Beispielhafte Ausgabe:
12.42

Hinweis
Um die Fläche zu berechnen, multiplizieren Sie die Länge mit der Breite. In diesem Fall 5.4*2.3=12.42

using System;

namespace I2bCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Länge des Raumes: ");
            //Seiten des Raumes
            double length;
            double width;
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Breite des Raumes: ");
            width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Der Raum ist: " + length * width + " m^2 gross");
        }

    }
}

Beachten Sie, dass die Variablen für die Längen vom Typ double sind, was es uns ermöglicht, Berechnungen mit den numerischen Fließkommatypen (reelle Zahlen) durchzuführen.


Frage 18:
Division

Was ist die Ausgabe dieses Codes?
int x = 16;
int y = 5;
Console.WriteLine(x/y);

3

Frage 19:
Modulo

Sie veranstalten eine Party für 7 Gäste. Alle von ihnen mögen Bier.
Schreiben Sie ein Programm, das die Anzahl der gekauften Bierflaschen als Eingabe nimmt und berechnet, wie viele Flaschen übrig bleiben, nachdem das Bier gleichmässig auf alle Gäste verteilt wurde.

Beispiel Eingabe
30

Beispielhafte Ausgabe
2

Verwenden Sie den Modulo-Operator %, um den Rest zu berechnen.

using System;

namespace I2bCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben sie die Anzahl der Personen an: ");

            int personen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geben sie die Anzahl der Biere an: ");
            int bier = Convert.ToInt32(Console.ReadLine());

            int übrigebier = bier % personen ;
            Console.WriteLine("Es sind: "+übrigebier +" Biere übrig");
        }

    }
}


Frage 20:
Zuweisungsoperatoren

Schreiben Sie ein Programm, das das Monatsgehalt als Eingabe nimmt und das Jahreseinkommen berechnet und ausgibt.

Beispiel Eingabe: 800

Beispiel Ausgabe: 9600

int Gehalt = Convert.ToInt32(Console.ReadLine());  

using System;

namespace I2bCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben sie ihr MOnats einkommen an: ");

            int einkommen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sie verdienen " + einkommen * 12 + " CHF im Jahr");
          
        }

    }
}


Frage 21:
Was ist die Ausgabe dieses Codes?

int a = 4;
int b = 6;
b = a++;
Console.WriteLine(++b);

6


Frage 22:
Flächeninhalt eines Kreises

Schreiben Sie ein Programm, das den Flächeninhalt eines Kreises berechnet.
Die von einem Kreis mit dem Radius r eingeschlossene Fläche ist πr², wobei π (pi) das konstante Verhältnis des Umfangs eines beliebigen Kreises zu seinem Durchmesser und r der Radius ist.
Das gegebene Programm deklariert eine konstante Variable pi mit dem Wert 3,14.
Vervollständigen Sie das Programm, um den Radius als Eingabe zu nehmen, dann den Flächeninhalt des Kreises zu berechnen und auszugeben.

Beispiel Eingabe: 5

Beispielhafte Ausgabe: 78.5

Hinweis: Denken Sie daran, den eingegebenen Wert in den Typ double zu konvertieren.

using System;

namespace I2bCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben sie den Kreis Radius an: ");
            const double pi = 3.14159;

            double raduis = Convert.ToDouble(Console.ReadLine());
            double fläche = Math.Pow(raduis * pi,2);
            Console.WriteLine("Der Kreis ist " + fläche + " gross");
          
        }

    }
}


Frage 23:
Die Else-Klausel

Sie erstellen eine mobile Zahlungsanwendung.
Schreiben Sie ein Programm, das eine Benutzerzahlung und einen ausstehenden Saldo als Eingabe annimmt.
Wenn der Saldo grösser oder gleich der Zahlung ist, soll das Programm "Erledigt" ausgeben, andernfalls soll das Programm "Zuwenig Geld" ausgeben.

Eingabebeispiel:
1570
14368.12

Zu erwartende Ausgabe:
Erledigt

using System;

namespace I2bCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben sie den Preis an: ");
            double payment = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geben sie ihr Geld an: ");
            double balance = Convert.ToDouble(Console.ReadLine());
            
            if (balance >= payment)
            {
                Console.WriteLine("Zahlung erfolgreich");
            } else
            {
                Console.WriteLine("Saldo zu klein");
            }
        }
    }
}

Frage 24:
switch

Erstellen Sie eine Anwendung für soziale Medien und müssen ein Menü entwickeln, in dem der Benutzer das Thema auswählen kann, über das er mehr erfahren möchte.

Hier sind die Themen durch entsprechende Nummern gekennzeichnet:
1 - Sport
2 - Politik
3 - Wirtschaft
4 - Technik
5 - Kunst

Schreiben Sie ein Programm, das die Nummer als Eingabe nimmt und den entsprechenden Themennamen ausgibt.

using System;

namespace I2bCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben sie ihre Intresse an: " +
                " 1 - Sports" +
                " 2 - Politics" +
                " 3 - Business" +
                " 4 - Technology" +
                " 5 - Art");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1: Console.WriteLine("Sports");
                    break;
                case 2: Console.WriteLine("Politics");
                    break;
                case 3: Console.WriteLine("Business");
                    break;
                case 4:
                    Console.WriteLine("Technology");
                    break;
                case 5:
                    Console.WriteLine("Art");
                    break;

            }

        }
    }
}



Frage 25:
Die while-Schleife

Schreiben Sie ein Programm, das N Zahlen als Eingabe nimmt und alle geraden Zahlen von 1 bis einschliesslich N ausgibt, jeweils in einer neuen Zeile.

Beispiel-Eingabe
9

Beispielhafte Ausgabe
2
4
6
8


using System;

namespace I2bCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben sie ihre Zahl an: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int res = 1;

            while (true)
            {
                if (res % 2 == 0)
                {
                    Console.WriteLine(res);                
                        }


                if(num == res)
                {
                    break;
                }
                res++;
            }

        }
    }
}


	

Frage 26:
Die for-Schleife


Das angegebene Programm nimmt eine positive Zahl N als Eingabe.
Vervollständigen Sie das Programm, um die Summe aller Zahlen von 1 bis einschließlich N zu berechnen.

Eingabebeispiel
4

Beispielhafte Ausgabe
10


namespace I2bCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            //hier kommt dein Code
            for (int i  = 1; i  <= N; i++)
            {
                sum = i + sum;
            }
            Console.WriteLine(sum);

        }
    }
}


Frage 27:
break

Wir erstellen ein Programm für eine Auktion mit einem eingestellten Maximalgebot. Die Anzahl der Gebote ist variabel.
Schreiben Sie ein Programm, das das Maximalgebot als Eingabe annimmt und dann alle Gebote der Auktionsteilnehmer annimmt, bis das Maximalgebot überschritten ist.
Das Programm soll die entsprechende Nachricht mit dem Gewinnergebot ausgeben.

Beispiel Eingabe
1600
800
1300
1700

Beispiel Ausgang
Verkauft: 1700

Erläuterung
Die erste Eingabe stellt das Maximalgebot dar, gefolgt von den Geboten aller Teilnehmer. Der letzte Teilnehmer hat ein Gebot (1700) abgegeben, das über dem Maximum (1600) liegt und die Auktion gewonnen. Somit wird dieses Gebot ausgegeben.

Hinweis
Um eine kontinuierliche Eingabeannahme zu ermöglichen, müssen Sie eine while(true)-Bedingung verwenden. Dieser Teil des Codes nimmt zum Beispiel unendlich viele Eingaben an:

using System;

namespace I2bCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben sie ein Höchstgebot an: ");
            int höchstgebot = Convert.ToInt32(Console.ReadLine());

            while (true)
            {

                int gebot = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Neues höchstes Gebot: " + gebot);



                if (gebot >= höchstgebot)
                {
                    break;
                    Console.WriteLine("Das höchstes Gebot war: " + gebot);
                }
            }

        }
    }
}

Verwenden Sie eine if-Anweisung innerhalb der Schleife, um die Abbruchbedingung auszuführen.


Frage 28:
Continue

Ein Geschäft führt eine einzigartige Werbeaktion durch. Wenn der Preis eines Artikels eine ungerade Zahl ist, ist der Artikel kostenlos.
Das Programm, das Sie erhalten, nimmt die Anzahl der gekauften Artikel als Eingabe, gefolgt von den Preisen der einzelnen Artikel, und gibt dann den Gesamtbetrag aus.
Ändern Sie den Code, um die ungeraden Preise zu überspringen und sie bei der Berechnung des Gesamtbetrags auszuschließen.

Eingabebeispiel
3
140
235
100

Beispiel Ausgang
240

Erläuterung
Die erste Eingabe stellt die Anzahl der gekauften Artikel dar, gefolgt von deren Preisen. Da 235 eine ungerade Zahl ist, sollen nur 140 und 100 addiert werden: 140+100 = 240.
using System;

namespace I2bCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geben sie die Anzahl der Produkte an");
            int amount = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            int totalAmount = 0;
            while (count < amount)
            {
                count++;
                Console.WriteLine("geben sie den Preis des Produktes an");
                int price = Convert.ToInt32(Console.ReadLine());
                if (price % 2 == 0)
                { 
              
                    totalAmount += price;
                } else
                {
                    continue;
                }
               
            }
            Console.WriteLine(totalAmount);
        }

        
    }
}

Frage 29:
Logische Operatoren

Studenten sollten mindestens 95 % Anwesenheit und eine Durchschnittsnote von 80 haben, um ein Stipendium zu erhalten.
Schreiben Sie ein Programm, das die Anwesenheit und den Notendurchschnitt als Eingabe akzeptiert und "Angenommen" ausgibt, wenn die angegebenen Anforderungen erfüllt sind, und "Abgelehnt", wenn sie nicht erfüllt sind.

Beispiel Eingabe
98
70

Beispiel Ausgabe
Abgelehnt

Verwenden Sie den &&-Operator, um die Bedingungen zu verketten

using System;

namespace I2bCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Geben sie ihre Awensheit an: ");
            int attendance = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Geben sie ihre Durchschnittsnote an");
            int avgScore = Convert.ToInt32(Console.ReadLine());
            if (attendance >= 95 && avgScore >= 80)
            {
                System.Console.WriteLine("Stipendium bekommen");
            }
            else
            {
                System.Console.WriteLine("Stipendium abgelehnt");
            }

        }


    }
}


Frage 30:
Vielfaches von 3

Sie sind ein Grundschullehrer und erklären den Schülern die Multiplikation.
Sie werden die Multiplikation mit 3 als Beispiel verwenden.
Das Programm, das Sie erhalten, nimmt N Zahlen als Eingabe. Schreiben Sie ein Programm, das alle Zahlen von 1 bis N ausgibt und dabei alle Zahlen, die Vielfache von 3 sind, durch "*" ersetzt.

Beispiel Eingabe
7

Beispiel Ausgabe
12*45*7

Die Zahl N ist ein Vielfaches von 3, wenn N%3==0.

using System;

namespace I2bCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Geben sie N an: ");
            int n = Convert.ToInt32(Console.ReadLine());



            for (int i = 0; i <= n; i++)
            {

                if (i % 3 == 0)
                {
                    Console.WriteLine("*,");
                    continue;
                }
                Console.WriteLine(i + ",");
            }

        }


    }
}

```
