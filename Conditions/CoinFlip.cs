using System;

public class CoinFlip
{
    public static void Run()
    {
        Random random = new();
        Console.WriteLine((random.NextDouble() > 0.5) ? "heads" : "tails");
    }
}