using System;

class Program
{
    string Wh= "n";  
    static void Main()
    {
        Console.WriteLine("Schreiben Sie einen Satz:"); 
        string strSatz = Console.ReadLine();
        Console.WriteLine("Wählen sie aus dden folgenden Optionen aus:");   

        Console.WriteLine("Anzahl der Wörter (1)");
        Console.WriteLine("Anzahl der Zeichen (2)");
        Console.WriteLine("Geben Sie die Zahl der gewünschten Option ein:");
        int iAuswahl = Convert.ToInt32(Console.ReadLine()); 

        switch (iAuswahl)
            {
            case 1:
                int wordCount = strSatz.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
                Console.WriteLine("Anzahl der Wörter: " + wordCount);
                break;
            case 2:
                Console.WriteLine("Anzahl der Zeichen: " + strSatz.Length);
                break;
            default:
                Console.WriteLine("Ungültige Option.");
                break;
            }
    }
}