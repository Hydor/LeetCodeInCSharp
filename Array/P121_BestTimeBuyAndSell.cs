
using System.Linq;
namespace LeetCode.Array
{
    class P121_BestTimeBuyAndSell
    {

        // One pass     O(n)    72.56%     45.79%
        public int MaxProfit(int[] prices)
        {
            if (prices.Count() < 2) return 0;
            var minPrice = prices.Max();
            var maxProfit = 0;

            for (int i = 0; i < prices.Count(); i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else if (prices[i] - minPrice > maxProfit)
                {
                    maxProfit = prices[i] - minPrice;
                }
            }
            return maxProfit;
        }
    }
}
