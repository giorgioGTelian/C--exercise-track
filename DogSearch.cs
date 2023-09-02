using System;
using System.Globalization;

public class Program
{
    public class Animal
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public string Personality { get; set; }
        public decimal SuggestedDonation { get; set; }
    }

    public static void Main()
    {
        Animal[] ourAnimals = 
        {
            new Animal { Type = "Dog", Description = "Small brown", Personality = "Playful", SuggestedDonation = 100m },
            new Animal { Type = "Dog", Description = "Large white", Personality = "Lazy", SuggestedDonation = 150m },
            new Animal { Type = "Cat", Description = "Fluffy", Personality = "Independent", SuggestedDonation = 50m }
        };

        Console.WriteLine("Enter pet characteristic search term:");
        string searchTerm = Console.ReadLine();

        Console.WriteLine("Dogs matching your search:");
        foreach (var animal in ourAnimals)
        {
            if (animal.Type == "Dog" && 
                (animal.Description.Contains(searchTerm) || animal.Personality.Contains(searchTerm)))
            {
                Console.WriteLine($"Description: {animal.Description}, Personality: {animal.Personality}");
                Console.WriteLine($"Suggested Donation: {animal.SuggestedDonation.ToString("C", CultureInfo.CurrentCulture)}");
            }
        }
    }
}
