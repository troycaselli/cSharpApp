using System;

public class BattleToTheDeath
{
    public static void Run()
    {
        Console.WriteLine("Enter First Contestant: ");
        string? contestant1 = Console.ReadLine()!;
        Console.WriteLine("Enter Second Contestant: ");
        string? contestant2 = Console.ReadLine()!;
        Console.WriteLine();

        int contestant1Health = 10;
        int contestant2Health = 10;
        Console.WriteLine($"{contestant1}: {contestant1Health}hp\t {contestant2}: {contestant2Health}hp\n");

        Random random = new();
        int roll = 0;

        while (contestant1Health > 0 && contestant2Health > 0)
        {
            roll = random.Next(0, 5);
            contestant2Health -= roll;
            if (roll == 0)
            {
                Console.WriteLine($"{contestant1} missed! {contestant2} still has {contestant2Health} hp remaining.\n");
            }
            else if (contestant2Health > 0)
            {
                Console.WriteLine($"{contestant1} inflicts {roll} damage! {contestant2} has {contestant2Health} hp remaining.\n");
            }
            else
            {
                Console.WriteLine($"{contestant1} wins!");
                break;
            }

            roll = random.Next(0, 5);
            contestant1Health -= roll;
            if (roll == 0)
            {
                Console.WriteLine($"{contestant2} missed! {contestant1} still has {contestant1Health} hp remaining.\n");
            }
            else if (contestant1Health > 0)
            {
                Console.WriteLine($"{contestant2} inflicts {roll} damage! {contestant1} has {contestant1Health} hp remaining.\n");
            }
            else
            {
                Console.WriteLine($"{contestant2} wins!");
                break;
            }
        }
    }
}