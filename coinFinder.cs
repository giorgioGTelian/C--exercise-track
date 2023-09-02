using System;
using System.Collections.Generic;

public class CoinFinder
{
    public List<Tuple<int, int>> TwoCoins(int[] coins, int target) 
    {
        List<Tuple<int, int>> result = new List<Tuple<int, int>>();

        for (int curr = 0; curr < coins.Length; curr++) 
        {
            for (int next = curr + 1; next < coins.Length; next++) 
            {    
                if (coins[curr] + coins[next] == target) 
                {
                    result.Add(new Tuple<int, int>(curr, next));
                }
            }
        }
        return result;
    }
}

public class Program
{
    public static void Main()
    {
        int target = 30;
        int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
        CoinFinder coinFinder = new CoinFinder();

        List<Tuple<int, int>> result = coinFinder.TwoCoins(coins, target);

        if (result.Count == 0) 
        {
            Console.WriteLine("No two coins make change");
        } 
        else 
        {
            Console.WriteLine("Change found at positions:");
            foreach (var pair in result)
            {
                Console.WriteLine($"{pair.Item1},{pair.Item2}");
            }
        }
    }
}
