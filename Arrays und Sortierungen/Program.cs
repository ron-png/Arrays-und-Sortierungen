using System;
using System.Collections.Generic;

namespace Arrays_und_Sortierungen
{
    class Program
    {

        // Aufgaben über arrays. Hilfsseite: https://learn.microsoft.com/de-de/dotnet/csharp/language-reference/builtin-types/arrays
        static void Main(string[] args)
        {
            // Alle Varianten. Zum Ausführen einer Variante das "//" vor der Variante entfernen!

            //Variante1();
            //Variante2();
            //Variante3();
            Variante4();
            //Variante5();
            //Variante6();
            //Variante7();
            //Variante8();
            //Variante9();
            //Variante10();
            //Zusatzaufgabe1();
            Console.ReadKey();
        }


        // Funktion, um Zahlen vom Benutzer zu bekommen
        static int ZahlHolen(string text)
        {
            // Für die Funktion Wichtige Variabeln
            int NutzerZahl; // Variabel, die die Eingabe des nutzers Speichert
            bool nummerTest; // Variabel um zu testen, ob die Eingabe eine Zahl ist

            // Frage ab nach Zahlen
            Console.WriteLine(text);

            // Überprüft, ob die Eingabe wirklich Zahl im Int32 Bereich ist. 
            // Wichtig, damit der Nutzer nicht das Programm durch fettfingern crasht
            // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/how-to-determine-whether-a-string-represents-a-numeric-value


            nummerTest = int.TryParse(Console.ReadLine(), out NutzerZahl); // ist die Eingabe eine Zahl?
            while (nummerTest == false) // Solange die Eingabe keine Zahl ist, soll der Nutzer erneut aufgefordert werden, 
                                        // eine Zahl einzugeben
            {
                Console.WriteLine("Deine Eingabe muss eine Zahl im Int32 Bereich sein."); // diese Aufforderung muss erst nach fehlerhafter Eingabe geschrieben werden
                Console.WriteLine(text);
                nummerTest = int.TryParse(Console.ReadLine(), out NutzerZahl);
            }
            // Wurde dann endlich eine Zahl eingegeben, Spuckt die Funktion diese aus.
            return NutzerZahl;
        }

        static void ArrayAusgabe()
        {
            int ArrayLaenge = 
            for (int i = 0; i < AnzahlArrayWerte; i++) // for loop, um das Array mit zufälligen Zahlen zu erstellen https://www.w3schools.com/cs/cs_for_loop.php
            {
                Console.WriteLine(array[i]);
            }
        }


        static void Variante1()
        // Erstellen Sie ein Programm, welches ein Array mit 10 Feldern anlegt und dieses mit Zahlen füllt.
        // Geben Sie dieses Arrays auf sinnvolle Weise auf dem Bildschirm aus.
        {   
            // Definiere Variabeln
            int counter;   // Counter, um sowohl den while loop zu beenden, als auch den richtigen Wert im array anzugeben
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Array mit den jeweiligen Werten

            counter = 0;
            while (counter < 10)
            {
                Console.WriteLine(array[counter]);
                counter++;
            }
        }

        static void Variante2()
        // Modifizieren Sie Variante 1 so, dass das Array mit zufälligen Zahlen gefüllt wird.
        {
            
            // Zufallszahlen generieren
            Random rnd = new Random();

            int[] array = new int[10]; // Definiert, wie lang das Array werden soll

            for (int i = 0; i < array.GetLength; i++) // for loop, um das Array mit zufälligen Zahlen zu erstellen https://www.w3schools.com/cs/cs_for_loop.php
            {
                array[i] = rnd.Next();
            }

        }

        static void Variante3()
        
        // Erstellen Sie zum Erzeugen und Füllen des Arrays aus Variante 2 eine Methode, welche anhand der
        // angegebenen Anzahl das jeweilige Array in der richtigen Größe erstellt und zurückgibt.

        // Lagern Sie außerdem die Ausgabe des Arrays in eine Methode aus und übergeben Sie dieser
        // Methode das Array.

        {
            // Definiere Variabeln
            int AnzahlArrayWerte;   // Counter, um sowohl den while loop zu beenden, als auch den richtigen Wert im array anzugeben

            // Zufallszahlen generieren
            Random rnd = new Random();

            AnzahlArrayWerte = ZahlHolen("Wie Viele Werte sollen in dem Array sein?");

            int[] array = new int[AnzahlArrayWerte]; // Definiert, wie lang das Array werden soll

            for (int i = 0; i < AnzahlArrayWerte; i++) // for loop, um das Array mit zufälligen Zahlen zu erstellen https://www.w3schools.com/cs/cs_for_loop.php
            {
                array[i] = rnd.Next();
                Console.WriteLine(array[i]);
            }
        }

        static void Variante4()
        // Ergänzen Sie die vorhergehende Variante um eine Eingabe, durch die der Benutzer auswählen kann,
        // wie groß das erstellte Array sein soll.Realisieren Sie diese Funktionalität ebenfalls in einer eigenen
        // Methode.
        {

        }

        static void Variante5()
        // Erstellen Sie eine neue Methode, durch die vom Array nur ein bestimmter, zusammenhängender
        // Bereich zurückgegeben wird (z.B.nur Elemente 2-5). Nutzen Sie diese, um das Array nur teilweise
        // auszugeben.
        {

        }

        static void Variante6()
        // Schreiben Sie eine Methode, welche zwei Elemente des Arrays miteinander vertauscht und geben Sie
        // ihr Array einmal im erstellten Zustand und einmal in einem vertauschten Zustand aus, der das Array
        // vollständig von hinten nach vorne vertauscht.
        {

        }

        static void Variante7()
        // Finden Sie heraus, wie Sie das Zahlenarray in C# auf einfache Weise sortieren können und
        // implementieren Sie diese Funktion.Geben Sie das Array sowohl vor, als auch nach der Sortierung
        // aus.
        {

        }

        static void Variante8()
        // Nun soll ein eigener Sortieralgorithmus realisiert werden.Überlegen Sie zunächst selbst, wie sie die
        // Sortierung von kleinen Arrays realisieren würden und schreiben Sie eine Methode zur Sortierung eines Arrays
        // von 3 Elementen.
        {

        }

        static void Variante9()
        // Überlegen Sie, ob sich ihre Methode aus Variante 6 auch für mehr als drei Elemente erweitern lässt.
        // Ist dies der Fall, versuchen Sie, diese Methode für ein größeres (beliebig großes) Array umzusetzen.
        // Sollte Ihre Idee nicht für mehr als drei Elemente funktionieren, schauen Sie sich bereits bekannte
        // Sortier-Algorithmen an und versuchen Sie, einen davon nachzubauen.
        // Einfache Algorithmen sind: SelectionSort, InsertionSort oder Bubblesort
        {

        }

        static void Variante10()
        // Zählen Sie, wie viele Änderungen das Array durchläuft, bis es sortiert wurde und geben Sie diese
        // Anzahl am Ende des Programms mit aus.
        {

        }

        static void Zusatzaufgabe1()
        // Implementieren Sie einen zweiten Sortieralgorithmus und ein Menü, durch welches der Benutzer
        // auswählen kann, mit welchem Verfahren sortiert wird.

        {

        }

    }
}
