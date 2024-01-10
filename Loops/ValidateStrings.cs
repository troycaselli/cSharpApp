using System;

public class ValidateStrings
{
    public static void Run()
    {
        Console.WriteLine("Enter role (Administrator, Manager, or User): ");
        string? userRole;
        bool validRole = false;

        do
        {
            userRole = Console.ReadLine()?.Trim().ToLower();

            if (userRole == null)
                Console.WriteLine("You must enter a role.");
            else if (userRole != "administrator" && userRole != "manager" && userRole != "user")
                Console.WriteLine("Invalid role. Enter Administrator, Manager, or User: ");
            else
                validRole = true;
        }
        while (!validRole);

        Console.WriteLine("Your entered role has been accepted!");
    }
}