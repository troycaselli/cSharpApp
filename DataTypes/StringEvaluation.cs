using System;

public class StringEvaluation
{
    public static void Run()
    {
        string[] values = { "12.3", "45", "ABC", "11", "DEF" };
        string message = "";
        decimal sum = 0m;
        decimal number;

        for (int i = 0; i < values.Length; i++)
        {
            if (decimal.TryParse(values[i], out number))
            {
                sum += number;
            }
            else
            {
                message += values[i];
            }
        }

        Console.WriteLine($"Message: {message}");
        Console.WriteLine($"Total: {sum}");
    }
}