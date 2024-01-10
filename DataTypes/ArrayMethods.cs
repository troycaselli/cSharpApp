using System;

public class ArrayMethods
{
    public static void Run()
    {
        string pangram = "The quick brown fox jumps over the lazy dog";
        string[] pangramArray = pangram.Split(' ');
        for (int i = 0; i < pangramArray.Length; i++)
        {
            char[] wordArray = pangramArray[i].ToCharArray();
            Array.Reverse(wordArray);
            pangramArray[i] = String.Join("", wordArray);
        }

        pangram = String.Join(" ", pangramArray);
        Console.WriteLine(pangram);

        string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
        string[] orders = orderStream.Split(",");
        Array.Sort(orders);

        for (int i = 0; i < orders.Length; i++)
        {
            if (orders[i].Length == 4)
            {
                Console.WriteLine(orders[i]);
            }
            else
            {
                Console.WriteLine($"{orders[i]}\t— Error");
            }
        }
    }
}