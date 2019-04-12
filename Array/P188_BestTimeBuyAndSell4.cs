using System;
using System.Linq;

namespace LeetCode.Array
{
    class P188_BestTimeBuyAndSell4
    {

        // One Pass    O(n*k)    100.00%    50.00%
        public int MaxProfit(int k, int[] prices)
        {
            if (k == 0 || prices.Count() <= 1) return 0;
            if (k > prices.Count() / 2) return quickSolution(prices);
            var inHandMoney = new int[2 * k];
            for (int j = 0; j < k; j++)
            {
                inHandMoney[j * 2] = int.MinValue;
            }
            foreach (var i in prices)
            {
                inHandMoney[0] = Math.Max(inHandMoney[0], -i);
                inHandMoney[1] = Math.Max(inHandMoney[1], inHandMoney[0] + i);
                for (int j = 1; j < k; j++)
                {
                    inHandMoney[j * 2] = Math.Max(inHandMoney[j * 2], inHandMoney[j * 2 - 1] - i);
                    inHandMoney[j * 2 + 1] = Math.Max(inHandMoney[j * 2 + 1], inHandMoney[j * 2] + i);
                }
            }
            return inHandMoney[2 * k - 1];
        }

        public int quickSolution(int[] prices)
        {
            var profit = 0;
            for (int i = 0; i < prices.Count() - 1; i++)
            {
                if (prices[i + 1] > prices[i]) profit += prices[i + 1] - prices[i];
            }
            return profit;
        }
    }
}
