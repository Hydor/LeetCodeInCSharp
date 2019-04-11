using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    class P219_ContainsDuplicate2
    {
        // Dictionary  O(n)  68.55%   31.25% 
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var i = 0;
            var dic = new Dictionary<int, int>();
            while (i < nums.Count())
            {
                if (dic.ContainsKey(nums[i]))
                {
                    if (i - dic[nums[i]] <= k) { return true; }
                    else { dic[nums[i]] = i; }
                }
                else
                {
                    dic.Add(nums[i], i);
                }
                i++;
            }
            return false;
        }
    }
}
