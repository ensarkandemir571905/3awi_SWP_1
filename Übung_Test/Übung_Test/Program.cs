using System;
using System.Globalization;

class Datentyp
{
    static void Main()
    {
        string? Nochmal = "n";
        do
        {
            Console.WriteLine("Gebe etwas ein um zu sehen, wie der Datentyp ist: ");
            string Eingabe = Console.ReadLine();

            if (int.TryParse(Eingabe, out int intValue))
            {
                Console.WriteLine($"Der Datentyp ist: Integer (int) mit dem Wert: {intValue}");
                break;
            }
            if (double.TryParse(Eingabe, out double doubleValue))
            {
                Console.WriteLine($"Der Datentyp ist: Double (double) mit dem Wert: {doubleValue}");
                break;
            }
            if (bool.TryParse(Eingabe, out bool boolValue))
            {
                Console.WriteLine($"Der Datentyp ist: Boolean (bool) mit dem Wert: {boolValue}");
                break;
            }
            if (char.TryParse(Eingabe, out char charValue))
            {
                Console.WriteLine($"Der Datentyp ist: Char (char) mit dem Wert: {charValue}");
                break;
            }
            Console.WriteLine($"Der Datentyp ist: String (string) mit dem Wert: {Eingabe}");
            

            Console.WriteLine("Willst du es nochmal versuchen? (j/n)");
            Nochmal = Console.ReadLine(); 
        } while (Nochmal == "j" || Nochmal == "J"); 
       
    }
        

}