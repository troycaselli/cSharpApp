using System;

public class TellAFortune
{
    private static readonly Random random = new();
    public static void Fortune()
    {
        int luck = random.Next(100);

        string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
        string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
        string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
        string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

        PrintFortune(luck, text, good, bad, neutral);
    }

    private static void PrintFortune(int luck, string[] text, string[] good, string[] bad, string[] neutral)
    {
        Console.WriteLine("A fortune teller whispers the following words:");
        string[] fortune = luck > 75 ? good : (luck < 25 ? bad : neutral);
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"{text[i]} {fortune[i]} ");
        }
        Console.WriteLine();
    }
}