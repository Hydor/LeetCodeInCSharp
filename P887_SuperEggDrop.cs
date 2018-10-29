using System;

namespace LeetCode
{
    class P887_SuperEggDrop
    {
        public int SuperEggDrop(int K, int N)
        {
            var dp = new int[N + 1];
            for (int i = 0; i <= N; ++i)
                dp[i] = i;

            for (int k = 2; k <= K; ++k)
            {
                var dp2 = new int[N + 1];
                var x = 1;
                for (int n = 1; n <= N; ++n)
                {
                    while (x < n && Math.Max(dp[x - 1], dp2[n - x]) > Math.Max(dp[x], dp2[n - x - 1]))
                        x++;

                    dp2[n] = 1 + Math.Max(dp[x - 1], dp2[n - x]);
                }

                dp = dp2;
            }

            return dp[N];
        }
    }
}
