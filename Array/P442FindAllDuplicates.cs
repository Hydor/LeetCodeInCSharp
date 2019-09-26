using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    class P442FindAllDuplicates
    {
        public IList<int> FindDuplicates(int[] nums)
        {

            // 1. Brute Force O(n^2)
            // 2. HashSet  O(n)  . But extra O(n) space needed
            // 3. Fast pointer, O(n)


            var result = new List<int>();
            if (nums == null || nums.Length == 0) return result;

            for (var i = 0; i < nums.Length; i++)
            {
                var fast = Math.Abs(nums[i]);
                if (nums[fast - 1] < 0)
                {
                    result.Add(fast);
                }
                else
                {
                    nums[fast - 1] = -1 * nums[fast - 1];
                }
            }
            return result;
        }
    }
}
