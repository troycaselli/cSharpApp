// terminal:
// dotnet build and/or dotnet run


// ======== VARIABLE SCOPE ======================================================

bool flag = true;
int value = 0;

if (flag)
{
    value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}
Console.WriteLine($"Outside of code block: {value}");


int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;

foreach (int number in numbers)
{
    total += number;

    if (number == 42)
    {
        Console.WriteLine("Set contains 42");
    }
}
Console.WriteLine($"Total: {total}");

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