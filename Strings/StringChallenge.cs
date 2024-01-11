using System;

public class StringChallenge
{
    public static void Run()
    {
        const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";
        string quantity = "";
        string output = "";
        const string openSpan = "<span>";
        const string closeSpan = "</span>";

        int quantityStart = input.IndexOf(openSpan);
        int quantityEnd = input.IndexOf(closeSpan);
        quantity = input.Substring(quantityStart += openSpan.Length, quantityEnd - quantityStart);
        output = input.Replace("trade", "reg").Replace("<div>", "").Replace("</div>", "");

        Console.WriteLine($"Quantity: {quantity}");
        Console.WriteLine($"Output: {output}");
    }
}