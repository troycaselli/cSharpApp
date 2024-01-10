using System;

public class StringFormatting
{
    public static void Run()
    {
        Console.WriteLine("1. Composite");
        string first = "Hello";
        string second = "World";
        string result = string.Format("{0}, {1}!", first, second);
        Console.WriteLine(result);
        Console.WriteLine("{0} {0} {0}!", first, second);

        Console.WriteLine("2. Interpolation");
        Console.WriteLine($"{first} {second}!");
        Console.WriteLine($"{first} {first} {first}!");

        Console.WriteLine("3. Currency");
        decimal price = 123.45m;
        int discount = 50;
        Console.WriteLine($"Price: {price:C} (Save {discount:C})");

        Console.WriteLine("4. Numbers with commas and rounding");
        decimal measurement = 1123456.78912m;
        Console.WriteLine($"Measurement: {measurement:N} units");
        Console.WriteLine($"Measurement: {measurement:N4} units");

        Console.WriteLine("5. Percentages with commas and rounding");
        decimal tax = .36785m;
        Console.WriteLine($"Tax rate: {tax:P}");
        Console.WriteLine($"Tax rate: {tax:P2}");

        Console.WriteLine("6. Combination");
        decimal price2 = 67.55m;
        decimal salePrice = 59.99m;
        string discount2 = string.Format("You saved {0:C2} off the regular {1:C2} price.", (price2 - salePrice), price2);
        discount2 += $"A discount of {((price2 - salePrice) / price2):P2}!";
        Console.WriteLine(discount2);

        string input = "Pad this";
        Console.WriteLine(input.PadLeft(12, '['));
        Console.WriteLine(input.PadRight(15, ']'));
    }
}