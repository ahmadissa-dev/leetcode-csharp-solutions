/*
Problem:
Given an array prices where prices[i] is the stock price on day i,
return the maximum profit from as many buy/sell transactions as needed

Approach:
Use a greedy approach
Add every positive price difference between consecutive days
This works because every upward movement can be treated as a profitable transaction

Time Complexity: O(n)
Space Complexity: O(1)
*/

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int totalProfit = 0;

        for (int day = 0; day < prices.Length - 1; day++)
        {
            int dailyProfit = prices[day + 1] - prices[day];

            if (dailyProfit > 0)
            {
                totalProfit += dailyProfit;
            }
        }

        return totalProfit;
    }
}