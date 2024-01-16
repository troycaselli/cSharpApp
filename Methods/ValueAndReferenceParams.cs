using System;

public class ValueAndReferenceParams
{
    public static void ValueParams(int a, int b, int c)
    {
        c = a * b;
        Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
    }

    public static void PrintArray(int[] array)
    {
        foreach (int a in array)
        {
            Console.Write($"{a} ");
        }
        Console.WriteLine();
    }

    public static void ClearArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = 0;
        }
    }

    public static void SetHealth(string status, bool isHealthy)
    {
        status = isHealthy ? "Healthy" : "Unhealthy";
        Console.WriteLine($"Middle: {status}");
    }
}