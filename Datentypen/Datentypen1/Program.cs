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
            Console.ReadKey();
            return;
        }

        if (bool.TryParse(eingabe, out bool wahrheitswert))
        {
            Console.WriteLine("Die Eingabe ist ein Bool.");
            Console.WriteLine("Wert: " + wahrheitswert);
            Console.ReadKey();
            return;
        }

        if (double.TryParse(eingabe, out double kommazahl))
        {
            Console.WriteLine("Die Eingabe ist eine rationale Zahl (double).");
            Console.WriteLine("Wert: " + kommazahl);
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Die Eingabe ist ein String.");
        Console.WriteLine("Wert: " + eingabe);

        Console.ReadKey();
    }
}