using System;

public class Exo3
{
    public static void Main()
    {
        Console.Write("Entrez un nombre: ");
        if(int.TryParse(Console.ReadLine(), out int number))
        {
            if (number%2 == 0) {
                Console.Write("pair");
            }
            else
            {
                Console.Write("impair");
            }
        }
        else
        {
            Console.WriteLine("Veuillez entrer un nombre entier valide.");
        }
    }
}