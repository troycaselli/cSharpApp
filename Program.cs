// terminal:
// dotnet build and/or dotnet run


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