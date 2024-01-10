using System;

public class DoWhileLoops
{
    public static void Run()
    {
        // Random random = new();
        // int current = 0;

        // do
        // {
        //     current = random.Next(1, 11);
        //     if (current >= 8) continue;
        //     Console.WriteLine(current);
        // } while (current != 7);


        Random random = new();
        int current = random.Next(1, 50);

        while (current >= 3)
        {
            Console.WriteLine(current);
            current = random.Next(1, current);
        }
        Console.WriteLine($"Last number: {current}");
    }
}