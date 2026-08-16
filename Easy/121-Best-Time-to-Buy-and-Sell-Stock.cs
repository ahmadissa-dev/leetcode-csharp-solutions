/*
Problem:
Given an array prices where prices[i] is the stock price on day i,
return the maximum profit from one buy and one sell transaction.

Approach:
Track the lowest price seen so far as the best buying price
For each current price, calculate the profit if selling at that price
Update the maximum profit whenever a better profit is found

Time Complexity: O(n)
Space Complexity: O(1)
*/

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int lowestPrice = prices[0];
        int maxProfit = 0;

        foreach (int currentPrice in prices)
        {
            lowestPrice = Math.Min(lowestPrice, currentPrice);

            int currentProfit = currentPrice - lowestPrice;

            maxProfit = Math.Max(maxProfit, currentProfit);
        }

        return maxProfit;
    }
}