
// - Iterate through the prices array.
// - Keep track of the minimum price seen so far.
// - At each step, calculate the profit if you sold on that day (current price - minimum price).
// - Update the maximum profit if this profit is greater than the previous


var prices = new[] { 8, 2, 6, 1, 4, 7 };
var result = MaxProfit(prices);
Console.WriteLine($"the maximum profit is {result}"); // Expected output: 6 (buy at 1, sell at 7)


static int MaxProfit(int[] prices)
{
    int profit = 0;
    int minPrice = prices[0];

    for (int i = 1; i < prices.Length; i++)
    {
        var currentPrice = prices[i];
        if (currentPrice < minPrice)
            minPrice = currentPrice;
        else if (currentPrice - minPrice > profit)
            profit = currentPrice - minPrice;
    }
    return profit;
}