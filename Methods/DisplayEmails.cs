using System;

public class Emails
{
    string[,] corporate =
    {
        {"Robert", "Bavin"}, {"Simon", "Bright"},
        {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
        {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
    };

    string[,] external =
    {
        {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
        {"Shay", "Lawrence"}, {"Daren", "Valdes"}
    };

    const string corporateDomain = "contoso.com";
    string externalDomain = "hayworth.com";


    public void GetCorporateEmails()
    {
        for (int i = 0; i < corporate.GetLength(0); i++)
        {
            DisplayEmails(corporate[i, 0], corporate[i, 1]);
        }

    }

    public void GetExternalEmails()
    {
        for (int i = 0; i < external.GetLength(0); i++)
        {
            DisplayEmails(external[i, 0], external[i, 1], externalDomain);
        }
    }

    void DisplayEmails(string firstName, string lastName, string domain = corporateDomain)
    {
        Console.WriteLine($"{firstName.Substring(0, 2).ToLower()}{lastName.ToLower()}@{domain}");
    }
}