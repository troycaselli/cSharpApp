using System;

public class Casting
{
    public static void Run()
    {
        int first = 2;
        string second = "4";
        Console.WriteLine(first + second);

        decimal myDecimal = 3.14m;
        Console.WriteLine($"decimal: {myDecimal}");
        int myInt = (int)myDecimal;
        Console.WriteLine($"int: {myInt}");

        string a = "5";
        string b = "7";
        // int sum = int.Parse(a) + int.Parse(b);
        int result = Convert.ToInt32(a) * Convert.ToInt32(b);
        Console.WriteLine(result);

        int value = (int)1.5m; // casting truncates
        Console.WriteLine(value);
        int value2 = Convert.ToInt32(1.5m); // converting rounds up
        Console.WriteLine(value2);

        string value3 = "102";
        int result3 = 0;
        if (int.TryParse(value3, out result3))
        {
            Console.WriteLine($"Measurement: {result3}");
        }
        else
        {
            Console.WriteLine("Unable to report the measurement.");
        }
        Console.WriteLine($"{5 + result3}");
    }
}