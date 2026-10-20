using System;

class Program
{
    static void Main()
    {
        char CWiederholung;

        do
        {
            Console.WriteLine("Bitte geben Sie die erste Zahl ein:");
            int iZahlEingabe1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bitte geben Sie die zweite Zahl ein:");
            int iZahlEingabe2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Wählen Sie eine Option aus:");
            Console.WriteLine("Addieren (1)");
            Console.WriteLine("Subtrahieren (2)");
            Console.WriteLine("Multiplizieren (3)");
            Console.WriteLine("Dividieren (4)");

            int iAuswahl = Convert.ToInt32(Console.ReadLine());

            switch (iAuswahl)
            {
                case 1:
                    Console.WriteLine("Ergebnis: " + (iZahlEingabe1 + iZahlEingabe2));
                    break;

                case 2:
                    Console.WriteLine("Ergebnis: " + (iZahlEingabe1 - iZahlEingabe2));
                    break;

                case 3:
                    Console.WriteLine("Ergebnis: " +
                        (iZahlEingabe1 * iZahlEingabe2));
                    break;

                case 4:
                    if (iZahlEingabe2 != 0)
                    {
                        Console.WriteLine("Ergebnis: " +
                            ((double)iZahlEingabe1 / iZahlEingabe2));
                    }
                    else
                    {
                        Console.WriteLine(
                            "Fehler: Division durch Null ist nicht erlaubt.");
                    }
                    break;

                default:
                    Console.WriteLine("Ungültige Auswahl.");
                    break;
            }

            Console.WriteLine(
                "Wollen Sie eine weitere Berechnung durchführen? (j/n)");

            CWiederholung = Convert.ToChar(Console.ReadLine());

        } while (CWiederholung == 'j' || CWiederholung == 'J');
    }
}