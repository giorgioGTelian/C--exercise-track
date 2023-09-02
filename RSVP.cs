using System;
using System.Collections.Generic;
using System.Linq;

public class RSVPSystem
{
    private readonly List<string> guestList = new List<string> { "Rebecca", "Nadia", "Noor", "Jonte" };
    private readonly List<string> rsvps = new List<string>();

    public void RSVP(string name, int partySize, string allergies, bool inviteOnly)
    {
        if (inviteOnly && !guestList.Contains(name))
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;
        }

        string rsvpEntry = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
        rsvps.Add(rsvpEntry);
    }

    public void ShowRSVPs()
    {
        Console.WriteLine("\nTotal RSVPs:");
        foreach (var rsvp in rsvps)
        {
            Console.WriteLine(rsvp);
        }
    }
}

public class Program
{
    public static void Main()
    {
        RSVPSystem rsvpSystem = new RSVPSystem();

        // Sample usage:
        rsvpSystem.RSVP("Rebecca", 2, "None", true);
        rsvpSystem.RSVP("John", 4, "Nuts", true);
        
        rsvpSystem.ShowRSVPs();
    }
}
