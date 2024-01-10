﻿// terminal:
// dotnet build and/or dotnet run

using System;

public class Program
{
    public static void Main()
    {
        // ====== CREATE FORM =======================================================

        string customerName = "Ms. Barros";
        string currentProduct = "Magic Yield";
        int currentShares = 2975000;
        decimal currentReturn = 0.1275m;
        decimal currentProfit = 55000000.0m;

        string newProduct = "Glorious Future";
        decimal newReturn = 0.13125m;
        decimal newProfit = 63000000.0m;

        Console.WriteLine($"Dear {customerName},");
        Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
        Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n");
        Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

        Console.WriteLine("Here's a quick comparison:\n");
        string comparisonMessage = "";

        comparisonMessage = $"{currentProduct}\t\t{currentReturn:P2}\t{currentProfit:c}\n{newProduct}\t\t{newReturn:P2}\t{newProfit:C}";

        Console.WriteLine(comparisonMessage);


        // ====== PURCHASING SHARES PROJECT ==========================================

        // int invoiceNumber = 1201;
        // decimal productShares = 25.4568m;
        // decimal subtotal = 2750.00m;
        // decimal taxPercentage = .15825m;
        // decimal total = 3185.19m;

        // Console.WriteLine($"Invoice Number: {invoiceNumber}");
        // Console.WriteLine($"\tShares: {productShares:N3}");
        // Console.WriteLine($"\tSubtotal: {subtotal:C}");
        // Console.WriteLine($"\t\tTax: {taxPercentage:P2}");
        // Console.WriteLine($"\tTotal: {total:C}");


        // ====== FORMATTING STRINGS ==================================================

        // Console.WriteLine("1. Composite");
        // string first = "Hello";
        // string second = "World";
        // string result = string.Format("{0}, {1}!", first, second);
        // Console.WriteLine(result);
        // Console.WriteLine("{0} {0} {0}!", first, second);

        // Console.WriteLine("2. Interpolation");
        // Console.WriteLine($"{first} {second}!");
        // Console.WriteLine($"{first} {first} {first}!");

        // Console.WriteLine("3. Currency");
        // decimal price = 123.45m;
        // int discount = 50;
        // Console.WriteLine($"Price: {price:C} (Save {discount:C})");

        // Console.WriteLine("4. Numbers with commas and rounding");
        // decimal measurement = 1123456.78912m;
        // Console.WriteLine($"Measurement: {measurement:N} units");
        // Console.WriteLine($"Measurement: {measurement:N4} units");

        // Console.WriteLine("5. Percentages with commas and rounding");
        // decimal tax = .36785m;
        // Console.WriteLine($"Tax rate: {tax:P}");
        // Console.WriteLine($"Tax rate: {tax:P2}");

        // Console.WriteLine("6. Combination");
        // decimal price2 = 67.55m;
        // decimal salePrice = 59.99m;
        // string discount2 = string.Format("You saved {0:C2} off the regular {1:C2} price.", (price2 - salePrice), price2);
        // discount2 += $"A discount of {((price2 - salePrice) / price2):P2}!";
        // Console.WriteLine(discount2);

        // string input = "Pad this";
        // Console.WriteLine(input.PadLeft(12, '['));
        // Console.WriteLine(input.PadRight(15, ']'));


        // ====== ARRAYS CHALLENGES ====================================================

        // string pangram = "The quick brown fox jumps over the lazy dog";
        // string[] pangramArray = pangram.Split(' ');
        // for (int i = 0; i < pangramArray.Length; i++)
        // {
        //     char[] wordArray = pangramArray[i].ToCharArray();
        //     Array.Reverse(wordArray);
        //     pangramArray[i] = String.Join("", wordArray);
        // }

        // pangram = String.Join(" ", pangramArray);
        // Console.WriteLine(pangram);

        // string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
        // string[] orders = orderStream.Split(",");
        // Array.Sort(orders);

        // for (int i = 0; i < orders.Length; i++)
        // {
        //     if (orders[i].Length == 4)
        //     {
        //         Console.WriteLine(orders[i]);
        //     }
        //     else
        //     {
        //         Console.WriteLine($"{orders[i]}\t— Error");
        //     }
        // }

        // ====== ARRAYS ================================================================

        // string[] pallets = { "B14", "A11", "B12", "A13" };

        // Console.WriteLine("Sorted...");
        // Array.Sort(pallets);
        // foreach (var pallet in pallets)
        // {
        //     Console.WriteLine($"-- {pallet}");
        // }

        // Console.WriteLine();
        // Console.WriteLine("Reversed...");
        // Array.Reverse(pallets);
        // foreach (var pallet in pallets)
        // {
        //     Console.WriteLine($"-- {pallet}");
        // }

        // Console.WriteLine();
        // Array.Clear(pallets, 0, 2);
        // Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
        // foreach (var pallet in pallets)
        // {
        //     Console.WriteLine($"-- {pallet}");
        // }

        // Console.WriteLine();
        // Array.Resize(ref pallets, 6);
        // Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

        // pallets[4] = "C01";
        // pallets[5] = "C02";

        // foreach (var pallet in pallets)
        // {
        //     Console.WriteLine($"-- {pallet}");
        // }

        // Console.WriteLine();
        // Array.Resize(ref pallets, 3);
        // Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

        // foreach (var pallet in pallets)
        // {
        //     Console.WriteLine($"-- {pallet}");
        // }

        // string value = "abc123";
        // char[] valueArray = value.ToCharArray();
        // Array.Reverse(valueArray);
        // string result = String.Join(",", valueArray);
        // Console.WriteLine(result);

        // string[] items = result.Split(",");
        // foreach (string item in items)
        // {
        //     Console.WriteLine(item);
        // }


        // ====== EVALUATE NUMBER TYPES ==================================================

        // int value1 = 12;
        // decimal value2 = 6.2m;
        // float value3 = 4.3f;

        // int result1 = (int)Math.Round(value1 / value2);
        // Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");


        // decimal result2 = value2 / (decimal)value3;
        // Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

        // float result3 = value3 / value1;
        // Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


        // ====== EVALUATE DATA ===========================================================

        // string[] values = { "12.3", "45", "ABC", "11", "DEF" };
        // string message = "";
        // decimal sum = 0m;
        // decimal number;

        // for (int i = 0; i < values.Length; i++)
        // {
        //     if (decimal.TryParse(values[i], out number))
        //     {
        //         sum += number;
        //     }
        //     else
        //     {
        //         message += values[i];
        //     }
        // }

        // Console.WriteLine($"Message: {message}");
        // Console.WriteLine($"Total: {sum}");


        // ====== TYPE CASTING ============================================================

        // int first = 2;
        // string second = "4";
        // Console.WriteLine(first + second);

        // decimal myDecimal = 3.14m;
        // Console.WriteLine($"decimal: {myDecimal}");
        // int myInt = (int)myDecimal;
        // Console.WriteLine($"int: {myInt}");

        // string a = "5";
        // string b = "7";
        // // int sum = int.Parse(a) + int.Parse(b);
        // int result = Convert.ToInt32(a) * Convert.ToInt32(b);
        // Console.WriteLine(result);

        // int value = (int)1.5m; // casting truncates
        // Console.WriteLine(value);
        // int value2 = Convert.ToInt32(1.5m); // converting rounds up
        // Console.WriteLine(value2);

        // string value3 = "102";
        // int result3 = 0;
        // if (int.TryParse(value3, out result3))
        // {
        //     Console.WriteLine($"Measurement: {result3}");
        // }
        // else
        // {
        //     Console.WriteLine("Unable to report the measurement.");
        // }
        // Console.WriteLine($"{5 + result3}");

        // ====== DATA TYPES ==============================================================

        // Console.WriteLine("Signed integral types:");
        // Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
        // Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
        // Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
        // Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

        // Console.WriteLine("\nUnsigned integral types:");
        // Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
        // Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
        // Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
        // Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

        // Console.WriteLine("\nFloating point types:");
        // Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
        // Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
        // Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

        // // reference types
        // int[] data = new int[3];

        // string shortenedString = "Hello World!";
        // Console.WriteLine(shortenedString);


        // ====== PROCESS CONTENTS OF STRING ARRAY ==========================================

        // string[] myStrings = new string[2]
        // {
        //     "I like pizza. I like roast chicken. I like salad",
        //     "I like all three of the menu choices"
        // };

        // int periodLocation = 0;

        // for (int i = 0; i < myStrings.Length; i++)
        // {
        //     do
        //     {
        //         myStrings[i] = myStrings[i].TrimStart();
        //         periodLocation = myStrings[i].IndexOf('.');
        //         if (periodLocation != -1)
        //         {
        //             Console.WriteLine(myStrings[i].Substring(0, periodLocation));
        //             myStrings[i] = myStrings[i].Substring(periodLocation + 1);
        //         }
        //         else
        //         {
        //             Console.WriteLine(myStrings[i]);
        //             break;
        //         }
        //     }
        //     while (periodLocation != -1);

        // }


        // ======= VALIDATE STRING INPUT =====================================================

        // Console.WriteLine("Enter role (Administrator, Manager, or User): ");
        // string? userRole;
        // bool validRole = false;

        // do
        // {
        //     userRole = Console.ReadLine().Trim().ToLower();

        //     if (userRole != "administrator" && userRole != "manager" && userRole != "user")
        //         Console.WriteLine("Invalid role. Enter Administrator, Manager, or User: ");
        //     else
        //         validRole = true;
        // }
        // while (!validRole);

        // Console.WriteLine("Your entered role has been accepted!");


        // ======= VALIDATE INT INPUT ========================================================

        // Console.WriteLine("Enter a number between 5 and 10: ");
        // string? enteredValue;
        // int number = 0;
        // bool validNumber = false;

        // do
        // {
        //     enteredValue = Console.ReadLine();
        //     validNumber = int.TryParse(enteredValue, out number);
        //     if (validNumber)
        //     {
        //         if (number >= 5 && number <= 10)
        //         {
        //             break;
        //         }
        //         else
        //         {
        //             Console.WriteLine($"You entered {number}. Please enter a number between 5 and 10.");
        //             validNumber = false;
        //         }
        //     }
        //     else
        //     {
        //         Console.WriteLine("Sorry, your entry is invalid; please try again");
        //     }
        // }
        // while (!validNumber);
        // Console.WriteLine($"Valid Number! {enteredValue}");


        // ======= BATTLE TO THE DEATH ========================================================

        // Console.WriteLine("Enter First Contestant: ");
        // string? contestant1 = Console.ReadLine()!;
        // Console.WriteLine("Enter Second Contestant: ");
        // string? contestant2 = Console.ReadLine()!;
        // Console.WriteLine();

        // int contestant1Health = 10;
        // int contestant2Health = 10;
        // Console.WriteLine($"{contestant1}: {contestant1Health}hp\t {contestant2}: {contestant2Health}hp\n");

        // Random random = new();
        // int roll = 0;

        // while(contestant1Health > 0 && contestant2Health > 0)
        // {
        //     roll = random.Next(0, 5);
        //     contestant2Health -= roll;
        //     if (roll == 0)
        //     {
        //         Console.WriteLine($"{contestant1} missed! {contestant2} still has {contestant2Health} hp remaining.\n");
        //     }
        //     else if (contestant2Health > 0)
        //     {
        //         Console.WriteLine($"{contestant1} inflicts {roll} damage! {contestant2} has {contestant2Health} hp remaining.\n");
        //     }
        //     else
        //     {
        //         Console.WriteLine($"{contestant1} wins!");
        //         break;
        //     }

        //     roll = random.Next(0, 5);
        //     contestant1Health -= roll;
        //     if (roll == 0)
        //     {
        //         Console.WriteLine($"{contestant2} missed! {contestant1} still has {contestant1Health} hp remaining.\n");
        //     }
        //     else if (contestant1Health > 0)
        //     {
        //         Console.WriteLine($"{contestant2} inflicts {roll} damage! {contestant1} has {contestant1Health} hp remaining.\n");
        //     }
        //     else
        //     {
        //         Console.WriteLine($"{contestant2} wins!");
        //         break;
        //     }
        // }


        // ======= DO-WHILE AND WHILE LOOPS ====================================================

        // Random random = new();
        // int current = 0;

        // do
        // {
        //     current = random.Next(1, 11);
        //     if (current >= 8) continue;
        //     Console.WriteLine(current);
        // } while (current != 7);


        // Random random = new();
        // int current = random.Next(1, 50);

        // while (current >= 3)
        // {
        //     Console.WriteLine(current);
        //     current = random.Next(1, current);
        // }
        // Console.WriteLine($"Last number: {current}");


        // ======= FIZZBUZZ CODING CHALLENGE ==========================================

        // for (int i = 1; i <= 100; i++)
        // {
        //     if (i % 3 == 0 && i % 5 == 0) Console.WriteLine($"{i} - FizzBuzz");
        //     else if (i % 3 == 0) Console.WriteLine($"{i} - Fizz");
        //     else if (i % 5 == 0) Console.WriteLine($"{i} - Buzz");
        //     else Console.WriteLine(i);
        // }


        // ======== FOR LOOP =========================================================

        // string[] names = {"Alex", "Eddie", "David", "Michael"};
        // for (int i = 0; i < names.Length; i++)
        // {
        //     Console.WriteLine(names[i]);
        // }

        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine(i);
        //     if (i == 7) break;
        // }



        // NUMBERS
        // DiceGame.Run();
        // SubscriptionRenewal.Run();

        // CONDITIONAL STATEMENTS
        // CoinFlip.Run();
        // FraudulentIDs.Run();
        // PermissionsLogic.Run();

        // Booleans.Run();

        // VariableScope.Run();

        // SwitchStatements.Run();


    }
}