using System;

public class ProductInfo
{
    public string Name { get; set; }
    public decimal ReturnRate { get; set; }
    public decimal Profit { get; set; }
    public int Shares { get; set; }
}

public class Program
{
    public static void Main()
    {
        string customerName = "Ms. Barros";

        ProductInfo currentProduct = new ProductInfo
        {
            Name = "Magic Yield",
            Shares = 2975000,
            ReturnRate = 0.1275m,
            Profit = 55000000.0m
        };

        ProductInfo newProduct = new ProductInfo
        {
            Name = "Glorious Future",
            ReturnRate = 0.13125m,
            Profit = 63000000.0m
        };

        DisplayMessage(customerName, currentProduct, newProduct);
        DisplayComparison(currentProduct, newProduct);
    }

    public static void DisplayMessage(string customer, ProductInfo current, ProductInfo newProduct)
    {
        Console.WriteLine($"Dear {customer},");
        Console.WriteLine($"As a customer of our {current.Name} offering, we are excited to tell you about a new financial product that would dramatically increase your return.\n");
        Console.WriteLine($"Currently, you own {current.Shares:N} shares at a return of {current.ReturnRate:P}.\n");
        Console.WriteLine($"Our new product, {newProduct.Name}, offers a return of {newProduct.ReturnRate:P}. Given your current volume, your potential profit would be {newProduct.Profit:C}.\n");
    }

    public static void DisplayComparison(ProductInfo current, ProductInfo newProduct)
    {
        Console.WriteLine("Here's a quick comparison:\n");

        string currentProductLine = $"{current.Name.PadRight(20)}{current.ReturnRate:P2}.PadRight(10)}{current.Profit:C2}.PadRight(20)}";
        string newProductLine = $"{newProduct.Name.PadRight(20)}{newProduct.ReturnRate:P2}.PadRight(10)}{newProduct.Profit:C2}.PadRight(20)}";

        Console.WriteLine(currentProductLine);
        Console.WriteLine(newProductLine);
    }
}
