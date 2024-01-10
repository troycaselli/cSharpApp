using System;

public class Booleans
{
    public static void Run()
    {
        string value1 = " a";
        string value2 = "A";
        Console.WriteLine(value1.Trim().ToUpper() == value2.Trim().ToUpper());

        string pangram = "The quick brown fox jumps over the lazy dog.";
        Console.WriteLine(pangram.Contains("fox"));
        Console.WriteLine(pangram.Contains("hello"));

        int a = 7;
        int b = 6;
        Console.WriteLine(a != b);
        int discount = 120 > 100 ? 10 : 5;
        Console.WriteLine($"Discount: {discount}");
    }
}