using System.Linq;

namespace LeetCode.Array
{
    class P122_BestTimeBuyAndSell
    {
        // One pass  O(n)    67.11%     80.39%
        public int MaxProfit(int[] prices)
        {
            if (prices.Count() <= 1) return 0;
            var profit = 0;
            for (int i = 0; i < prices.Count() - 1; i++)
            {
                if (prices[i + 1] > prices[i]) profit += prices[i + 1] - prices[i];
            }
            return profit;
        }
    }
}
