using System;

public class DiceGame
{
    public static void Run()
    {
        var dice = new Random();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        int total = roll1 + roll2 + roll3;

        Console.WriteLine(total);

        if (roll1 == roll2 && roll2 == roll3)
        {
            Console.WriteLine("You rolled triples! +6 bonus points added");
            total += 6;
            Console.WriteLine(total);

        }
        else if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
        {
            Console.WriteLine("You rolled doubles! +2 bonus points added");
            total += 2;
            Console.WriteLine(total);
        }

        if (total >= 18)
        {
            Console.WriteLine("You win $500!!!");
        }
        else if (total >= 12 && total <= 17)
        {
            Console.WriteLine("You win $10!");
        }
        else
        {
            Console.WriteLine("You lose.");
        }
    }
}