
using System;

class Program
{
    string strWiedrholung = "j"; 
    static void Main()
    {
       
        Console.WriteLine("Bitte geben Sie eine Zahl oder eine Zeichenkette ein:");
        string eingabe = Console.ReadLine();

        int zahl;

        if (int.TryParse(eingabe, out zahl))
        {
            Console.WriteLine("Sie haben eine ganze Zahl eingegeben.");
            Console.WriteLine("Welche mathematische Operation möchten Sie darauf ausführen?");
            Console.WriteLine("(1) Addition");
            Console.WriteLine("(2) Multiplikation");
            Console.WriteLine("(3) Division");
            Console.WriteLine("(4) Fakultät");
            Console.WriteLine("(5) Wurzelziehen");

            string auswahl = Console.ReadLine();

            switch (auswahl)
            {
                case "1":
                    Console.WriteLine("Bitte geben Sie eine zweite Zahl ein:");
                    int zahl2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ergebnis: " + (zahl + zahl2));
                    break;

                case "2":
                    Console.WriteLine("Bitte geben Sie eine zweite Zahl ein:");
                    zahl2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ergebnis: " + (zahl * zahl2));
                    break;

                case "3":
                    Console.WriteLine("Bitte geben Sie eine zweite Zahl ein:");
                    zahl2 = int.Parse(Console.ReadLine());

                    if (zahl2 != 0)
                    {
                        Console.WriteLine("Ergebnis: " + ((double)zahl / zahl2));
                    }
                    else
                    {
                        Console.WriteLine("Division durch 0 ist nicht erlaubt.");
                    }
                    break;

                case "4":
                    long fakultaet = 1;

                    for (int i = 1; i <= zahl; i++)
                    {
                        fakultaet = fakultaet * i;
                    }

                    Console.WriteLine("Fakultät: " + fakultaet);
                    break;

                case "5":
                    if (zahl >= 0)
                    {
                        Console.WriteLine("Wurzel: " + Math.Sqrt(zahl));
                    }
                    else
                    {
                        Console.WriteLine("KEINE NEGATIVEN ZAHLEN!!");
                    }
                    break;

                default:
                    Console.WriteLine("Ungültige Auswahl.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Sie haben eine Zeichenkette eingegeben. Was wollen Sie damit machen?");
            Console.WriteLine("(1) Alle Selbstlaute (a,e,i,o,u) entfernen");
            Console.WriteLine("(2) Die Zeichenkette umdrehen");
            Console.WriteLine("(3) Die Anzahl an Zeichen ausgeben");

            string auswahl = Console.ReadLine();

            switch (auswahl)
            {
                case "1":
                    string Selbstlaute = "";

                    foreach (char zeichen in eingabe)
                    {
                        if ("aeiouAEIOU".Contains(zeichen) == false)
                        {
                            Selbstlaute = Selbstlaute + zeichen;
                        }
                    }

                    Console.WriteLine("Ergebnis: " + Selbstlaute);
                    break;

                case "2":
                    char[] zeichenArray = eingabe.ToCharArray();
                    Array.Reverse(zeichenArray);

                    string umgedreht = new string(zeichenArray);

                    Console.WriteLine("Ergebnis: " + umgedreht);
                    break;

                case "3":
                    Console.WriteLine("Anzahl der Zeichen: " + eingabe.Length);
                    break;

                default:
                    Console.WriteLine("Ungültige Auswahl.");
                    break;
            }
        }

        Console.WriteLine("Drücken Sie eine Taste zum Beenden.");
        Console.ReadKey();
    }
}
