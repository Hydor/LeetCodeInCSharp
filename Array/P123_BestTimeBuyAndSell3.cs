using System;
using System.Linq;

namespace LeetCode.Array
{
    class P123_BestTimeBuyAndSell3
    {
        public int MaxProfit(int[] prices)
        {
            var buy1 = int.MinValue;
            var sell1 = 0;
            var buy2 = int.MinValue;
            var sell2 = 0;
            for (int i = 0; i < prices.Count(); i++)
            {
                buy1 = Math.Max(buy1, 0 - prices[i]);
                sell1 = Math.Max(sell1, prices[i] + buy1);
                buy2 = Math.Max(buy2, sell1 - prices[i]);
                sell2 = Math.Max(sell2, prices[i] + buy2);
            }
            return sell2;
        }
    }
}
