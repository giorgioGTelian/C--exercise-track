using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        string sku = "01-MN-L";

        string[] product = sku.Split('-');

        Dictionary<string, string> productTypes = new Dictionary<string, string>
        {
            { "01", "Sweat shirt" },
            { "02", "T-Shirt" },
            { "03", "Sweat pants" }
        };

        Dictionary<string, string> productColors = new Dictionary<string, string>
        {
            { "BL", "Black" },
            { "MN", "Maroon" }
        };

        Dictionary<string, string> productSizes = new Dictionary<string, string>
        {
            { "S", "Small" },
            { "M", "Medium" },
            { "L", "Large" }
        };

        string type = productTypes.ContainsKey(product[0]) ? productTypes[product[0]] : "Other";
        string color = productColors.ContainsKey(product[1]) ? productColors[product[1]] : "White";
        string size = productSizes.ContainsKey(product[2]) ? productSizes[product[2]] : "One Size Fits All";

        Console.WriteLine($"Product: {size} {color} {type}");
    }
}
