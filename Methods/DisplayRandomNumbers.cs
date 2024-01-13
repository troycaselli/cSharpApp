using System;

public class DisplayRandomNumbers
{
    public static void RandomNumberGenerator()
    {
        Random random = new();
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"{random.Next(1, 100)} ");
        }
        Console.WriteLine();
    }
}


