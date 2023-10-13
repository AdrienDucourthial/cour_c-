using System;

public class Exo2
{
    public static void Main()
    {
        Console.WriteLine(ConvertToUpper("minuscule"));
    }

    public static string ConvertToUpper(string text)
    {
        return text.ToUpper();
    }
}