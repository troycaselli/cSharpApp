using System;

public class ForLoops
{
    public static void Run()
    {
        string[] names = { "Alex", "Eddie", "David", "Michael" };
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
            if (i == 7) break;
        }
    }
}