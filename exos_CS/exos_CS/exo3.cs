using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Entrez un nombre: ");
        if(int.TryParse(Console.ReadLine(), out int number))
        {
           ..... 
        }
        else
        {
            Console.WriteLine("Veuillez entrer un nombre entier valide.");
        }
    }
}