using System;

namespace LeetCode
{
    class P887_SuperEggDrop
    {
        public static int SuperEggDrop(int eggs, int floors)
        {
            var dp = new int[floors + 1];
            var cost = new int[eggs-1];
            var firstDropFloor = new int[eggs-1];
            for (int i = 0; i <= floors; ++i)
                dp[i] = i;

            for (int e = 2; e <= eggs; ++e)
            {

                var dp2 = new int[floors + 1];
                var x = 1;
                for (int f = 1; f <= floors; ++f)
                {
                    while (x < f && Math.Max(dp[x - 1], dp2[f - x]) > Math.Max(dp[x], dp2[f - x - 1]))
                        x++;

                    dp2[f] = 1 + Math.Max(dp[x - 1], dp2[f - x]);

                }
                dp = dp2;
                cost[e - 2] = e * 699 + dp2[floors] * 199;  // Or we can pass in parameter x and y
                firstDropFloor[e - 2] = x;
                                
            }
            var minCost = 0;
            var minIndex = 0;
            for (int i=0; i< cost.Length; i++)
            {
                if (minCost > cost[i] || minCost == 0)
                {
                    minCost = cost[i];
                    minIndex = i;
                }
            }
            return firstDropFloor[minIndex];
        }

       
    }


    //public string FindPathSumK(int[][] array, int k)
    //{
    //    var dp = new int[array.Length][array[0].Length];
    //    var path = "";
    //    for (var i = array.Length - 1; i >= 0; i--)
    //    {
    //        var iPath = "";
    //        for (int j = array[0].Length - 1; j >= 0; j--)
    //        {
    //            if (i == array.Length - 1 && j != array[0].Length - 1)
    //                dp[i][j] = array[i][j] + dp[i][j + 1];
    //            else if (j == array[0].Length - 1 && i != array.Length - 1)
    //                dp[i][j] = array[i][j] + dp[i + 1][j];
    //            else if (j != array[0].Length - 1 && i != array.Length - 1)
    //            {
    //                dp[i][j] = array[i][j] + Math.Min(dp[i + 1][j], dp[i][j + 1]);
    //                iPath = i.ToString() + ',' + j.ToString() + '|';
    //            }
    //            else
    //                dp[i][j] = array[i][j];
    //            if (dp[0][0] == k) path = iPath;
    //        }
    //    }
    //    return path;
    //}
}
