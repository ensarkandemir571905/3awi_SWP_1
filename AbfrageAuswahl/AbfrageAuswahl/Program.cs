using System;

class Programm
{
    static void Main()
    {
        int iAuswahl;
        int iEingabe;
        int iErgebnis;
        char cWh = 'j';

        do
        {
            Console.WriteLine("Geben Sie eine natürliche Zahl ein:");
            iEingabe = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Was möchten Sie mit der Zahl " + iEingabe + " tun?");

            Console.WriteLine("Wählen Sie einen der Optionen aus:");
            Console.WriteLine("Opton 1: Quadrat");
            Console.WriteLine("Option 2: Wurzel");
            Console.WriteLine("Option 3: Fakultät");
            iAuswahl = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Du hast " + iAuswahl + " gewählt");

            switch (iAuswahl)
            {
              case 1:
                    Console.WriteLine("Sie haben Quadrat gewählt.");
                    iErgebnis = iEingabe * iEingabe;
                    Console.WriteLine("Das Quadrat von " + iEingabe + " ist " + iErgebnis);
                    break;
                case 2:
                    Console.WriteLine("Sie haben Wurzel gewählt.");
                    iErgebnis = (int)Math.Sqrt(iEingabe);
                    Console.WriteLine("Die Wurzel von " + iEingabe + " ist " + iErgebnis);
                    break;
                case 3:
                    Console.WriteLine("Sie haben Fakultät gewählt.");
                    iErgebnis = 1;
                    for (int i = 1; i <= iEingabe; i++)
                    {
                        iErgebnis *= i;
                    }
                    Console.WriteLine("Die Fakultät von " + iEingabe + " ist " + iErgebnis);
                    break;
                default:
                    Console.WriteLine("Ungültige Auswahl.");
                    break;
            }

            Console.WriteLine("Möchten Sie eine weitere Zahl eingeben? (j/n)");
            cWh = Convert.ToChar(Console.ReadLine());
        }  while(cWh == 'j' || cWh == 'J');
    }
}