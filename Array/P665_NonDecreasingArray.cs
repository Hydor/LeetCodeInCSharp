using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    class P665_NonDecreasingArray
    {
        // 91%  &  100%
        public bool CheckPossibility(int[] nums)
        {
            var count = 0;
            if (nums.Count() <= 2) { return true; }
            else
            {
                for (int i = 0; i < nums.Count() - 2; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        count++;
                        if (i > 0 && nums[i] > nums[i + 2] && nums[i - 1] > nums[i + 1]) { return false; }
                    }

                    if (count >= 2) return false;
                }
            }
            if (nums[nums.Count() - 2] > nums[nums.Count() - 1]) count++;

            return count < 2;
        }
    }
}
