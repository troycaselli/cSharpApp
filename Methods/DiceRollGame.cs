using System;

public class DiceRollGame
{
    int target;
    int roll;
    Random random  = new();

    public void PlayDiceGame()
    {
        GetTarget();
        RollDice();
        ShouldPlay();
    }

    void GetTarget()
    {
        target = random.Next(1, 6);
        Console.WriteLine($"The target to beat is {target}. Good luck!");
    }

    void RollDice()
    {
        Console.Write("Roll the dice by pressing enter.");
        Console.ReadLine();
        roll = random.Next(1,7);
        WinOrLose(target, roll);
    }

    // retrieve user input and determine if the user wants to play again
    void ShouldPlay()
    {
        string? input;
        Console.WriteLine();
        Console.WriteLine("Would you like to play again?? If so, enter 'y'.");
        input = Console.ReadLine();
        if(input == "y" || input == "Y")
        {
            PlayDiceGame();
        }
    }

    // determine if the player has won or lost
    void WinOrLose(int target, int roll)
    {
        if(roll > target)
        {
            Console.WriteLine($"Congratulations! You rolled a {roll} which is higher than the target.");
        }
        else
        {
            Console.WriteLine($"Oh, no! You rolled a {roll} which is lower than the target.");
            
        }

    }
}