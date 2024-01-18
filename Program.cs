// terminal:
// dotnet build and/or dotnet run

using System;

namespace MyNamespace
{
    public class Program
    {
        public static void Main()
        {
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


            // DATA TYPES
            // DataTypes.Run();
            // Casting.Run();
            // StringEvaluation.Run();
            // NumberEvaluation.Run();
            // ArrayEvaluation.Run();
            // ArrayMethods.Run();
            // StringFormatting.Run();
            // PurchasingShares.Run();
            // CreateForm.Run();


            // STRINGS
            // StringMethods.Run();
            // StringChallenge.Run();


            // METHODS
            // DisplayRandomNumbers.RandomNumberGenerator();

            // TrackMedication.Run();

            // int[] schedule = { 800, 1200, 1600, 2000 };
            // TrackMedication.RunWithParameters(schedule, 6, -6);

            // ValidateIPv4 validator = new();
            // validator.Validate();

            // TellAFortune.Fortune();

            // int a = 3;
            // int b = 4;
            // int c = 0;
            // ValueAndReferenceParams.ValueParams(a, b, c);
            // Console.WriteLine($"global statement: {a} x {b} = {c}");

            // int[] array = { 1, 2, 3, 4, 5 };
            // ValueAndReferenceParams.PrintArray(array);
            // ValueAndReferenceParams.ClearArray(array);
            // ValueAndReferenceParams.PrintArray(array);

            // string status = "Healthy";
            // Console.WriteLine($"Start: {status}");
            // ValueAndReferenceParams.SetHealth(status, false);
            // Console.WriteLine($"End: {status}");

            // RSVP RSVPInstance = new();
            // RSVPInstance.MakeRSVP("Rebecca");
            // RSVPInstance.MakeRSVP("Nadia", 2, "Nuts");
            // RSVPInstance.MakeRSVP(name: "Linh", partySize: 2, inviteOnly: false);
            // RSVPInstance.MakeRSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
            // RSVPInstance.MakeRSVP("Noor", 4, inviteOnly: false);
            // RSVPInstance.MakeRSVP("Jonte", 2, "Stone fruit", false);
            // RSVPInstance.ShowRSVPs();

            // Emails EmailsInstance = new();
            // EmailsInstance.GetCorporateEmails();
            // EmailsInstance.GetExternalEmails();

            // Purchases PurchasesInstance = new();
            // PurchasesInstance.CalculatePurchases();

            // Currency CurrencyInstance = new();
            // CurrencyInstance.DisplayCurrency();

            // Coins CoinsInstance = new();
            // CoinsInstance.CheckCoins();

            // DiceRollGame DiceInstance = new();
            // DiceInstance.PlayDiceGame();

            ContosoZoo ContosoZooInstance = new();
            ContosoZooInstance.CreateGroups();

        }
    }
}