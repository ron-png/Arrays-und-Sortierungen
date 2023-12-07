using System;
using System.Collections.Generic;

namespace Arrays_und_Sortierungen
{
    class Program
    {

        // Aufgaben über arrays. Hilfsseite: https://learn.microsoft.com/de-de/dotnet/csharp/language-reference/builtin-types/arrays
        static void Main(string[] args)
        {
            //Variante1();
            Variante2();
            //Variante3();
            //Variante4();
            //Variante5();
            //Variante6();
            //Variante7();
            //Variante8();
            //Variante9();
            //Variante10();
            //Variante11();
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

            int[] array = new int[10]; // Definiert, wie lang das Array werden soll?

            for (int i = 0; i < 10; i++)
            {
                array[i] = rnd.Next();
                Console.WriteLine(array[i]);
            }

        }

        static void Variante3()
        {
            // Definiere Variabeln
            int counter, AnzahlArrayWerte;   // Counter, um sowohl den while loop zu beenden, als auch den richtigen Wert im array anzugeben

            // Zufallszahlen generieren
            Random rnd = new Random();

            AnzahlArrayWerte = ZahlHolen("Wie Viele Werte sollen in dem Array sein?");

            List<int> arrayListe = new List<int> { };  // https://stackoverflow.com/questions/202813/adding-values-to-a-c-sharp-array

            for (int runs = 0; runs < AnzahlArrayWerte; runs++)
            {
                arrayListe.Add(rnd.Next());
            }

            
            int[] array = arrayListe.ToArray(); // Array mit den jeweiligen Werten

       

            counter = 0;
            while (counter < 10)
            {
                Console.WriteLine(array[counter]);
                counter++;
            }
        }

        static void Variante4()
        {

        }

        static void Variante5()
        {

        }

        static void Variante6()
        {

        }

        static void Variante7()
        {

        }

        static void Variante8()
        {

        }

        static void Variante9()
        {

        }

        static void Variante10()
        {

        }

        static void Variante11()
        {

        }

        static void Zusatzaufgabe1()
        {

        }

    }
}
