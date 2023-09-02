using System;

public class Program
{
    public static void Main()
    {
        int[] times = { 800, 1200, 1600, 2000 };
        
        Console.WriteLine("Enter current GMT");
        int currentGMT = GetValidatedGMTInput();

        Console.WriteLine("Current Medicine Schedule:");
        DisplayMedicineTimes(times);

        Console.WriteLine("\nEnter new GMT");
        int newGMT = GetValidatedGMTInput();

        if (IsValidGMT(currentGMT) && IsValidGMT(newGMT))
        {
            AdjustMedicineTimes(times, currentGMT, newGMT);
            Console.WriteLine("New Medicine Schedule:");
            DisplayMedicineTimes(times);
        }
        else
        {
            Console.WriteLine("Invalid GMT");
        }
    }

    private static int GetValidatedGMTInput()
    {
        return Convert.ToInt32(Console.ReadLine());
    }

    private static bool IsValidGMT(int gmt)
    {
        return Math.Abs(gmt) <= 12;
    }

    private static void DisplayMedicineTimes(int[] times)
    {
        foreach (int val in times)
        {
            Console.Write($"{FormatTime(val)} ");
        }
        Console.WriteLine();
    }

    private static string FormatTime(int timeValue)
    {
        string time = timeValue.ToString();
        int len = time.Length;

        if (len >= 3)
        {
            return time.Insert(len - 2, ":");
        }
        else if (len == 2)
        {
            return time.Insert(0, "0:");
        }
        else
        {
            return time.Insert(0, "0:0");
        }
    }

    private static void AdjustMedicineTimes(int[] times, int currentGMT, int newGMT)
    {
        int diff = 100 * (newGMT - currentGMT);

        for (int i = 0; i < times.Length; i++)
        {
            times[i] = (times[i] + diff + 2400) % 2400;
        }
    }
}
