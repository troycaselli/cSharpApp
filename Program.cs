// terminal:
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

        // LOOPS
        // ForLoops.Run();
        // FizzBuzz.Run();
        // DoWhileLoops.Run();
        // BattleToTheDeath.Run();
        // ValidateInts.Run();
        // ValidateStrings.Run();
        // ProcessStringArray.Run();

    }
}