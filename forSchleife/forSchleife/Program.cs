
Console.Write("Gib eine Zahl ein: ");
int zahl = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Das Ergebnis von " + zahl + " * " + i + " = " + (zahl * i));
    Console.WriteLine (zahl*i);
}