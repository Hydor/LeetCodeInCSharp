using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Array
{
    class P1_TwoSum
    {

        //Dictionary   O(n)   87%    25%
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            var resultInd = new int[2];
            for (int i = 0; i < nums.Count(); i++)
            {
                var needNum = target - nums[i];
                if (dict.ContainsKey(nums[i]))
                {
                    resultInd[0] = dict[nums[i]];
                    resultInd[1] = i;
                    return resultInd;
                }
                else if (!dict.ContainsKey(needNum)) { dict.Add(needNum, i); }
            }
            return resultInd;
        }
    }
}
