using System;

public class PurchasingShares
{
    public static void Run()
    {
        int invoiceNumber = 1201;
        decimal productShares = 25.4568m;
        decimal subtotal = 2750.00m;
        decimal taxPercentage = .15825m;
        decimal total = 3185.19m;

        Console.WriteLine($"Invoice Number: {invoiceNumber}");
        Console.WriteLine($"\tShares: {productShares:N3}");
        Console.WriteLine($"\tSubtotal: {subtotal:C}");
        Console.WriteLine($"\t\tTax: {taxPercentage:P2}");
        Console.WriteLine($"\tTotal: {total:C}");
    }
}