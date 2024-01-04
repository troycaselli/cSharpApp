// terminal:
// dotnet build and/or dotnet run

// ====== ARRAYS ================================================================

string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine();
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine();
Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine();
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine();
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(",");
foreach (string item in items)
{
    Console.WriteLine(item);
}

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


// ======== SWITCH STATEMENTS ==================================================

// int employeeLevel = 100;
// string employeeName = "John Smith";
// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }
// Console.WriteLine($"{employeeName}, {title}");


// // SKU = Stock Keeping Unit.
// // SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";
// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch (product[0])
// {
//     case "01":
//         type = "Sweat shirt";
//         break;
//     case "02":
//         type = "T-Shirt";
//         break;
//     case "03":
//          type = "Sweat pants";
//          break;
//     default:
//         type = "Other";
//         break;
// }

// switch (product[1])
// {
//     case "BL":
//         color = "Black";
//         break;
//     case "MN":
//         color ="Maroon";
//         break;
//     default:
//         color = "White";
//         break;
// }

// switch (product[2])
// {
//     case "S":
//         size = "Small";
//         break;
//     case "M":
//         size = "Medium";
//         break;
//     case "L":
//         size = "Large";
//         break;
//     default:
//         size = "One Size Fits All";
//         break;
// }
// Console.WriteLine($"Product: {size} {color} {type}");


// ======= PERMISSIONS LOGIC ===================================================

// string permission = "Admin|Manager";
// int level = 55;

// if(permission.Contains("Admin"))
// {
//     Console.WriteLine((level > 55) ? "Welcome, Super Admin user." : "Welcome, Admin user.");
// }
// else if(permission.Contains("Manager"))
// {
//     Console.WriteLine((level >= 20) ? "Contact an Admin for access." : "You do not have sufficient privileges.");
// }
// else
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }


// ======== VARIABLE SCOPE ======================================================

// bool flag = true;
// int value = 0;

// if (flag)
// {
//     value = 10;
//     Console.WriteLine($"Inside of code block: {value}");
// }
// Console.WriteLine($"Outside of code block: {value}");


// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0;

// foreach (int number in numbers)
// {
//     total += number;

//     if (number == 42)
//     {
//         Console.WriteLine("Set contains 42");
//     }
// }
// Console.WriteLine($"Total: {total}");


// ======== COIN FLIPPER ========================================================

// Random random = new();
// Console.WriteLine((random.NextDouble() > 0.5) ? "heads" : "tails");


// ========= BOOLEAN EXPRESSIONS =================================================

// string value1 = " a";
// string value2 = "A";
// Console.WriteLine(value1.Trim().ToUpper() == value2.Trim().ToUpper());

// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("hello"));

// int a = 7;
// int b = 6;
// Console.WriteLine(a != b);
// int discount = 120 > 100 ? 10 : 5;
// Console.WriteLine($"Discount: {discount}");


// ========= REPORTING FRAUDULENT IDS =============================================

// string[] ids = {"B123",
// "C234",
// "A345",
// "C15",
// "B177",
// "G3003",
// "C235",
// "B179"};

// foreach (string id in ids)
// {
//     if(id.StartsWith("B"))
//     {
//         Console.WriteLine(id);
//     }
// }


// ========= SUBSCRIPTION RENEWAL =================================================

// var random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// Console.WriteLine(daysUntilExpiration);

// if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// else if (daysUntilExpiration == 1)
// {
//     discountPercentage = 20;
//     Console.WriteLine($"Your subscription expires within a day! Renew now and save {discountPercentage}%!");
// }
// else if (daysUntilExpiration > 1 && daysUntilExpiration <= 5)
// {
//     discountPercentage = 10;
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. Renew now and save {discountPercentage}%!");
// }
// else if (daysUntilExpiration > 5 && daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }
// else
// {
//     return;
// }


// ============= DICE GAME ==================================================

// var dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine(total);

// if (roll1 == roll2 && roll2 == roll3) {
//     Console.WriteLine("You rolled triples! +6 bonus points added");
//     total += 6;
//     Console.WriteLine(total);

// } 
// else if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
// {
//     Console.WriteLine("You rolled doubles! +2 bonus points added");
//     total += 2;
//     Console.WriteLine(total);
// }

// if(total >= 18)
// {
//     Console.WriteLine("You win $500!!!");
// }
// else if (total >= 12 && total <= 17)
// {
//     Console.WriteLine("You win $10!");
// }
// else
// {
//     Console.WriteLine("You lose.");
// }