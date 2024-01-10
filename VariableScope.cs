using System;

public class VariableScope
{
    public static void Run()
    {
        bool flag = true;
        int value = 0;

        if (flag)
        {
            value = 10;
            Console.WriteLine($"Inside of code block: {value}");
        }
        Console.WriteLine($"Outside of code block: {value}");


        int[] numbers = { 4, 8, 15, 16, 23, 42 };
        int total = 0;

        foreach (int number in numbers)
        {
            total += number;

            if (number == 42)
            {
                Console.WriteLine("Set contains 42");
            }
        }
        Console.WriteLine($"Total: {total}");
    }
}