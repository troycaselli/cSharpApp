using System;

public class ValidateInts
{
    public static void Run()
    {
        Console.WriteLine("Enter a number between 5 and 10: ");
        string? enteredValue;
        int number = 0;
        bool validNumber = false;

        do
        {
            enteredValue = Console.ReadLine();
            validNumber = int.TryParse(enteredValue, out number);
            if (validNumber)
            {
                if (number >= 5 && number <= 10)
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"You entered {number}. Please enter a number between 5 and 10.");
                    validNumber = false;
                }
            }
            else
            {
                Console.WriteLine("Sorry, your entry is invalid; please try again");
            }
        }
        while (!validNumber);
        Console.WriteLine($"Valid Number! {enteredValue}");
    }
}