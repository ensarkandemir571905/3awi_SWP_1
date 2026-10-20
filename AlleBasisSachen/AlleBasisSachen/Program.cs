
using System;
using System.Collections.Generic;

namespace CSharpLernprogramm
{
    internal class Program
    {
        // =====================================================
        // HAUPTPROGRAMM
        // Hier beginnt das Programm.
        // =====================================================

        static void Main(string[] args)
        {
            Console.Title = "Mein C#-Lernprogramm";

            Console.WriteLine("==================================");
            Console.WriteLine("     WILLKOMMEN BEI C#!");
            Console.WriteLine("==================================");

            Console.WriteLine("Ich erkläre dir jetzt die Basics.");
            Console.WriteLine();

            // Die einzelnen Lektionen aufrufen
            VariablenErklaeren();
            Benutzereingabe();
            Rechnen();
            Bedingungen();
            ForSchleife();
            WhileSchleife();
            ArraysUndListen();
            MethodenErklaeren();
            KlassenUndObjekte();
            Fehlerbehandlung();

            Console.WriteLine();
            Console.WriteLine("Alle Lektionen wurden beendet!");
            Console.WriteLine("Drücke Enter zum Beenden.");
            Console.ReadLine();
        }

        // =====================================================
        // 1. VARIABLEN UND DATENTYPEN
        // =====================================================

        static void VariablenErklaeren()
        {
            Console.WriteLine("\n--- 1. VARIABLEN ---");

            // int speichert ganze Zahlen
            int alter = 18;

            // double speichert Kommazahlen
            double groesse = 1.80;

            // string speichert Text
            string name = "Alex";

            // bool speichert true oder false
            bool istProgrammierer = true;

            // char speichert ein einzelnes Zeichen
            char buchstabe = 'A';

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Alter: " + alter);
            Console.WriteLine("Größe: " + groesse);
            Console.WriteLine("Programmierer: " + istProgrammierer);
            Console.WriteLine("Buchstabe: " + buchstabe);

            // $ vor einem String ermöglicht String-Interpolation.
            // Variablen können direkt in { } eingesetzt werden.
            Console.WriteLine($"Hallo {name}, du bist {alter} Jahre alt.");
        }

        // =====================================================
        // 2. BENUTZEREINGABEN
        // =====================================================

        static void Benutzereingabe()
        {
            Console.WriteLine("\n--- 2. BENUTZEREINGABE ---");

            Console.Write("Wie heißt du? ");

            // ReadLine liest eine Texteingabe ein.
            string name = Console.ReadLine() ?? "";

            Console.WriteLine($"Hallo {name}!");

            Console.Write("Wie alt bist du? ");

            string eingabe = Console.ReadLine() ?? "";

            // TryParse versucht, Text in eine Zahl umzuwandeln.
            // So stürzt das Programm bei falscher Eingabe nicht ab.
            if (int.TryParse(eingabe, out int alter))
            {
                Console.WriteLine($"Du bist {alter} Jahre alt.");

                if (alter >= 18)
                {
                    Console.WriteLine("Du bist volljährig.");
                }
                else
                {
                    Console.WriteLine("Du bist noch minderjährig.");
                }
            }
            else
            {
                Console.WriteLine("Das war keine gültige ganze Zahl.");
            }
        }

        // =====================================================
        // 3. MATHEMATIK
        // =====================================================

        static void Rechnen()
        {
            Console.WriteLine("\n--- 3. RECHNEN ---");

            int a = 10;
            int b = 3;

            Console.WriteLine($"Addition:       {a} + {b} = {a + b}");
            Console.WriteLine($"Subtraktion:    {a} - {b} = {a - b}");
            Console.WriteLine($"Multiplikation: {a} * {b} = {a * b}");
            Console.WriteLine($"Division:       {a} / {b} = {a / b}");

            // Bei int wird das Ergebnis der Division abgerundet.
            // Für Kommazahlen verwenden wir double.
            double ergebnis = (double)a / b;

            Console.WriteLine($"Komma-Division: {ergebnis}");

            // Modulo % gibt den Rest einer Division zurück.
            Console.WriteLine($"Rest: {a} % {b} = {a % b}");

            // Beispiel: Prüfen, ob eine Zahl gerade ist.
            int zahl = 8;

            if (zahl % 2 == 0)
            {
                Console.WriteLine($"{zahl} ist gerade.");
            }
        }

        // =====================================================
        // 4. BEDINGUNGEN: IF, ELSE IF, ELSE
        // =====================================================

        static void Bedingungen()
        {
            Console.WriteLine("\n--- 4. BEDINGUNGEN ---");

            int punkte = 75;

            // == bedeutet gleich
            // != bedeutet ungleich
            // > bedeutet größer
            // < bedeutet kleiner
            // >= bedeutet größer oder gleich
            // <= bedeutet kleiner oder gleich

            if (punkte >= 90)
            {
                Console.WriteLine("Note: Sehr gut!");
            }
            else if (punkte >= 75)
            {
                Console.WriteLine("Note: Gut!");
            }
            else if (punkte >= 50)
            {
                Console.WriteLine("Note: Bestanden.");
            }
            else
            {
                Console.WriteLine("Nicht bestanden.");
            }

            // && bedeutet UND
            // || bedeutet ODER
            // ! bedeutet NICHT
            bool hatTicket = true;
            bool istAltGenug = true;

            if (hatTicket && istAltGenug)
            {
                Console.WriteLine("Du darfst eintreten.");
            }
        }

        // =====================================================
        // 5. FOR-SCHLEIFE
        // =====================================================

        static void ForSchleife()
        {
            Console.WriteLine("\n--- 5. FOR-SCHLEIFE ---");

            // Eine for-Schleife wiederholt Code.
            // int i = 1: Startwert
            // i <= 5: Bedingung
            // i++: i wird nach jedem Durchlauf erhöht

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Durchlauf Nummer {i}");
            }
        }

        // =====================================================
        // 6. WHILE-SCHLEIFE
        // =====================================================

        static void WhileSchleife()
        {
            Console.WriteLine("\n--- 6. WHILE-SCHLEIFE ---");

            int zaehler = 1;

            // Solange die Bedingung true ist,
            // wird der Code erneut ausgeführt.
            while (zaehler <= 3)
            {
                Console.WriteLine($"Zähler: {zaehler}");

                // Wichtig: Den Zähler verändern,
                // sonst könnte die Schleife endlos laufen.
                zaehler++;
            }
        }

        // =====================================================
        // 7. ARRAYS UND LISTEN
        // =====================================================

        static void ArraysUndListen()
        {
            Console.WriteLine("\n--- 7. ARRAYS UND LISTEN ---");

            // Ein Array speichert mehrere Werte.
            // Die Positionen beginnen bei 0.
            string[] spiele = { "Minecraft", "Minecraft Dungeons", "Terraria" };

            Console.WriteLine($"Erstes Spiel: {spiele[0]}");
            Console.WriteLine($"Zweites Spiel: {spiele[1]}");

            // Alle Array-Einträge ausgeben.
            foreach (string spiel in spiele)
            {
                Console.WriteLine($"Spiel: {spiel}");
            }

            // Eine List kann dynamisch wachsen.
            List<string> namen = new List<string>();

            namen.Add("Max");
            namen.Add("Lisa");
            namen.Add("Tom");

            // Ein Element hinzufügen
            namen.Add("Anna");

            // Anzahl der Elemente
            Console.WriteLine($"Anzahl der Namen: {namen.Count}");

            // Ein Element entfernen
            namen.Remove("Tom");

            foreach (string name in namen)
            {
                Console.WriteLine(name);
            }
        }

        // =====================================================
        // 8. EIGENE METHODEN
        // =====================================================

        // Eine Methode ist ein benannter Codeblock,
        // den du mehrfach aufrufen kannst.

        static void MethodenErklaeren()
        {
            Console.WriteLine("\n--- 8. METHODEN ---");

            Begruessung();

            // Einer Methode kann man Werte übergeben.
            BegruessePerson("Sam");

            // Eine Methode kann auch etwas zurückgeben.
            int summe = Addiere(5, 7);

            Console.WriteLine($"5 + 7 = {summe}");
        }

        // void bedeutet: Diese Methode gibt keinen Wert zurück.
        static void Begruessung()
        {
            Console.WriteLine("Willkommen!");
        }

        // string name ist ein Parameter.
        static void BegruessePerson(string name)
        {
            Console.WriteLine($"Hallo {name}!");
        }

        // int vor dem Methodennamen bedeutet,
        // dass die Methode eine ganze Zahl zurückgibt.
        static int Addiere(int zahl1, int zahl2)
        {
            return zahl1 + zahl2;
        }

        // =====================================================
        // 9. KLASSEN UND OBJEKTE
        // =====================================================

        static void KlassenUndObjekte()
        {
            Console.WriteLine("\n--- 9. KLASSEN UND OBJEKTE ---");

            // Ein Objekt wird aus einer Klasse erstellt.
            // Die Klasse ist der Bauplan, das Objekt das Exemplar.
            Person person = new Person("Alex", 20);

            person.Vorstellen();

            // Eigenschaften eines Objekts ändern.
            person.Alter = 21;

            Console.WriteLine($"Neues Alter: {person.Alter}");
        }

        // =====================================================
        // 10. FEHLERBEHANDLUNG
        // =====================================================

        static void Fehlerbehandlung()
        {
            Console.WriteLine("\n--- 10. FEHLERBEHANDLUNG ---");

            try
            {
                Console.Write("Gib eine Zahl ein: ");

                string eingabe = Console.ReadLine() ?? "";

                // Convert.ToInt32 kann bei ungültigem Text
                // eine Ausnahme (Exception) auslösen.
                int zahl = Convert.ToInt32(eingabe);

                Console.WriteLine($"Deine Zahl: {zahl}");
            }
            catch (FormatException)
            {
                // Dieser Block wird bei ungültigem Zahlenformat
                // ausgeführt.
                Console.WriteLine("Fehler: Das war keine ganze Zahl.");
            }
            catch (Exception fehler)
            {
                // Allgemeine Fehler sollten möglichst gezielt
                // behandelt werden.
                Console.WriteLine($"Ein Fehler ist aufgetreten: {fehler.Message}");
            }
            finally
            {
                // finally wird nach try/catch ausgeführt,
                // auch wenn ein behandelter Fehler auftritt.
                Console.WriteLine("Eingabe beendet.");
            }
        }
    }

    // =========================================================
    // EINE EIGENE KLASSE
    // =========================================================

    class Person
    {
        // Eigenschaften beschreiben die Daten eines Objekts.
        public string Name { get; set; }

        public int Alter { get; set; }

        // Der Konstruktor wird beim Erstellen des Objekts
        // mit new Person(...) aufgerufen.
        public Person(string name, int alter)
        {
            Name = name;
            Alter = alter;
        }

        // Eine Methode der Klasse.
        public void Vorstellen()
        {
            Console.WriteLine(
                $"Ich heiße {Name} und bin {Alter} Jahre alt."
            );
        }
    }
}
