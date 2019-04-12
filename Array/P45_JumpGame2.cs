using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    class P45_JumpGame2
    {
        // Greedy    O(n)    76.11%    81.82%
        public int Jump(int[] nums)
        {
            if (nums.Count() <= 1) return 0;
            var steps = 0;
            var stepEnd = 0;
            var currentFurthest = 0;
            for (int i = 0; i < nums.Count(); i++)
            {
                if (stepEnd >= nums.Count() - 1) return steps;
                currentFurthest = Math.Max(i + nums[i], currentFurthest);
                if (i == stepEnd)
                {
                    stepEnd = currentFurthest;
                    steps++;
                }
            }
            return steps;
        }
    }
}
