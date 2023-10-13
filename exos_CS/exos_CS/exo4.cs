using System;
using System.Collections.Generic;

public class Exo4
{
    static List<char> alphabet = new List<char>
    {
        'a','b','c','d','e','f','g','h','i','j','k','l','m',
        'n','o','p','q','r','s','t','u','v','w','x','y','z'
    };

    public static void Main()
    {
        AlgoTest(MyNameIs);
        //Console.ReadLine();
        Console.Write(MyNameIs("Ahmed")+ "\n");
        Console.Write(MyNameIs("Dorlean") + "\n");
        Console.Write(MyNameIs("a") + "\n");
        Console.Write(MyNameIs("Sandrine") + "\n");
    }

    public static string MyNameIs(string name)
    {
        // myNameIs("Ahmed") should return  '071243'
        // myNameIs("Dorlean") return 31417114013
        // myNameIs("a") return  0
        // myNameIs("Sandrine") return 180133178134
        string result = "";
        
        foreach (char c in name.ToLower())
        {
            for (int i=0; i<26; i++)
            {
                if (c == alphabet[i]) {
                    result += i.ToString();
                }
            }
        }
        return result;
    }

    public static void AlgoTest(Func<string, string> func)
    {
        if (func("AB") == "01")
        {
            Console.WriteLine("Success");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}