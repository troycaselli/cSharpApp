using System;

public class RSVP
{
    string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
    string[] rsvps = new string[10];
    int count = 0;
    public void MakeRSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
    {
        if (inviteOnly)
        {
            bool found = false;
            foreach (string guest in guestList)
            {
                if (guest.Equals(name))
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine($"Sorry, {name} is not on the guest list");
                return;
            }
        }

        rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
        count++;
    }

    public void ShowRSVPs()
    {
        Console.WriteLine("\nTotal RSVPs:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(rsvps[i]);
        }
    }

}