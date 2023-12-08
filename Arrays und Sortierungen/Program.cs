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
            Variante3();
            //Variante4();
            //Variante5();
            //Variante6();
            //Variante7();
            //Variante8();
            //Variante9();
            //Variante10();
            //Zusatzaufgabe1();
            Console.ReadKey();
        }


        // Funktion, um Zahlen vom Benutzer zu bekommen, überprüft auch, ob die Angabe wirklich eine Int32 Zahl ist
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
        } // Code kommt aus altem Codeknacker Projekt. Siehe https://github.com/ron-png/Codeknacker

        // Methode, um die Arrays auszugeben
        static void ArrayAusgabe(int[] arrayAngabe)
        {

            for (int i = 0; i < arrayAngabe.GetLength(0); i++) // for loop, um das Array mit zufälligen Zahlen zu erstellen https://www.w3schools.com/cs/cs_for_loop.php
            {
                Console.Write(arrayAngabe[i] + " ");


                // Für die schöne Darstellung haben wir hier eine neue Zeile nach den ersten fünf Werten
                if (i % 5 == 4) // Modulo Lösung dank unseres Lehrers!
                {
                    Console.WriteLine();
                }
            }
        }

        // Methode, um ein Array zu erstelllen
        static int[] ArrayErstellen(int arraydimension0)
        {
            int[] array1 = new int[arraydimension0]; // Definiert, wie lang das Array werden soll

            // zum Zufallszahlen generieren...
            Random rnd = new Random();

            for (int i = 0; i < array1.GetLength(0); i++) // for loop, um das Array mit zufälligen Zahlen zu erstellen https://www.w3schools.com/cs/cs_for_loop.php
            {
                array1[i] = rnd.Next();
            }

            return array1;
        }

        // Variante 1:
        // Erstellen Sie ein Programm, welches ein Array mit 10 Feldern anlegt und dieses mit Zahlen füllt.
        // Geben Sie dieses Arrays auf sinnvolle Weise auf dem Bildschirm aus.
        static void Variante1()

        {
            // Erstelle Array und fülle diesen direkt mir Daten
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Array mit den jeweiligen Werten


            // Ausgabe des Arrays
            for (int i = 0; i < array.GetLength(0); i++) // GetLength(0) In der Klammer wird die Dimenson des Arrays angegeben, von dem die Länge ergriffen werden soll
            {
                Console.Write(array[i] + " ");
            }
        }



        // Variante 2:
        // Modifizieren Sie Variante 1 so, dass das Array mit zufälligen Zahlen gefüllt wird.
        static void Variante2()
        {

            // Zufallszahlen generieren
            Random rnd = new Random();

            // Erstellen des Arrays
            int[] array = new int[10]; // Definiert, wie lang das Array werden soll

            // Befülllen des Arrays mit Werten
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = rnd.Next();
            }


            // Ausgabe des Arrays
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write(array[i] + " ");

                // Für die schöne Darstellung haben wir hier eine neue Zeile nach den ersten fünf Werten
                if (i % 5 == 4) // Modulo Lösung dank unseres Lehrers!
                {
                    Console.WriteLine();
                }
            }

        }



        // Variante 3:
        // Erstellen Sie zum Erzeugen und Füllen des Arrays aus Variante 2 eine Methode, welche anhand der
        // angegebenen Anzahl das jeweilige Array in der richtigen Größe erstellt und zurückgibt.

        // Lagern Sie außerdem die Ausgabe des Arrays in eine Methode aus und übergeben Sie dieser
        // Methode das Array.
        static void Variante3()
        {
            // Definiere Variabeln
            int AnzahlArrayWerte;   // Variabel, die für die Eingabe des Nutzers zur Länge des Arrays speichert

            // zum Zufallszahlen generieren...
            Random rnd = new Random();

            // Fragt jetzt den Nutzer nach seiner gewünschten Arraylänge
            AnzahlArrayWerte = ZahlHolen("Wie Viele Werte sollen in dem Array sein?");

            int[] arrayVariante3;

            arrayVariante3 = ArrayErstellen(AnzahlArrayWerte);

            //int[] array1 = new int[AnzahlArrayWerte]; // Definiert, wie lang das Array werden soll

            //for (int i = 0; i < array1.GetLength(0); i++) // for loop, um das Array mit zufälligen Zahlen zu erstellen https://www.w3schools.com/cs/cs_for_loop.php
            //{
            //    array1[i] = rnd.Next();
            //}                               

            // ruft die Methode auf, um den Array Auszugeben
            ArrayAusgabe(arrayVariante3);
        }




        // Variante 4:
        // Ergänzen Sie die vorhergehende Variante um eine Eingabe, durch die der Benutzer auswählen kann,
        // wie groß das erstellte Array sein soll.Realisieren Sie diese Funktionalität ebenfalls in einer eigenen
        // Methode.
        static void Variante4()
        {

        }


        // Variante 5:
        // Erstellen Sie eine neue Methode, durch die vom Array nur ein bestimmter, zusammenhängender
        // Bereich zurückgegeben wird (z.B.nur Elemente 2-5). Nutzen Sie diese, um das Array nur teilweise
        // auszugeben.
        static void Variante5()
        {

        }


        // Variante 6:
        // Schreiben Sie eine Methode, welche zwei Elemente des Arrays miteinander vertauscht und geben Sie
        // ihr Array einmal im erstellten Zustand und einmal in einem vertauschten Zustand aus, der das Array
        // vollständig von hinten nach vorne vertauscht.
        static void Variante6()
        {

        }


        // Variante 7:
        // Finden Sie heraus, wie Sie das Zahlenarray in C# auf einfache Weise sortieren können und
        // implementieren Sie diese Funktion.Geben Sie das Array sowohl vor, als auch nach der Sortierung
        // aus.
        static void Variante7()
        {

        }


        // Variante 8:
        // Nun soll ein eigener Sortieralgorithmus realisiert werden.Überlegen Sie zunächst selbst, wie sie die
        // Sortierung von kleinen Arrays realisieren würden und schreiben Sie eine Methode zur Sortierung eines Arrays
        // von 3 Elementen.
        static void Variante8()
        {

        }


        // Variante 9:
        // Überlegen Sie, ob sich ihre Methode aus Variante 6 auch für mehr als drei Elemente erweitern lässt.
        // Ist dies der Fall, versuchen Sie, diese Methode für ein größeres (beliebig großes) Array umzusetzen.
        // Sollte Ihre Idee nicht für mehr als drei Elemente funktionieren, schauen Sie sich bereits bekannte
        // Sortier-Algorithmen an und versuchen Sie, einen davon nachzubauen.
        // Einfache Algorithmen sind: SelectionSort, InsertionSort oder Bubblesort
        static void Variante9()
        {

        }


        // Variante 10:
        // Zählen Sie, wie viele Änderungen das Array durchläuft, bis es sortiert wurde und geben Sie diese
        // Anzahl am Ende des Programms mit aus.
        static void Variante10()
        {

        }


        // Zusatzaufgabe 1:
        // Implementieren Sie einen zweiten Sortieralgorithmus und ein Menü, durch welches der Benutzer
        // auswählen kann, mit welchem Verfahren sortiert wird.
        static void Zusatzaufgabe1()
        {

        }

    }
}