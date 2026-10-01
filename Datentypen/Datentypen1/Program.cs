
using System;

class Program
{
    static void Main()
    {
        Console.Write("Geben Sie etwas ein: ");
        string eingabe = Console.ReadLine();

        if (int.TryParse(eingabe, out int ganzeZahl))
        {
            Console.WriteLine("Die Eingabe ist ein Integer.");
            Console.WriteLine("Wert: " + ganzeZahl);
        }
        else if (bool.TryParse(eingabe, out bool wahrheitswert))
        {
            Console.WriteLine("Die Eingabe ist ein Bool.");
            Console.WriteLine("Wert: " + wahrheitswert);
        }
        else if (double.TryParse(eingabe, out double kommazahl))
        {
            Console.WriteLine("Die Eingabe ist eine rationale Zahl (double).");
            Console.WriteLine("Wert: " + kommazahl);
        }
        else
        {
            Console.WriteLine("Die Eingabe ist ein String.");
            Console.WriteLine("Wert: " + eingabe);
        }

        Console.WriteLine();
        Console.WriteLine("Drücken Sie eine Taste zum Beenden...");
        Console.ReadKey();
    }
}



