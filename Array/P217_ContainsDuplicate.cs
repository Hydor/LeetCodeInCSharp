using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    class P217_ContainsDuplicate
    {
        //Dictionary   O(n)    87%   13%
        public bool ContainsDuplicate(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            if (nums.Count() <= 1) return false;
            var i = 0;
            while (i < nums.Count())
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], 1); i++;
                }
                else return true;
            }
            return false;
        }
}
}
