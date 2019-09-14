using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DFS
{
    class P78Subsets
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums == null)
            {
                return result;
            }
            var nullsubset = new List<int>();
            if (nums.Length == 0)
            {
                result.Add(nullsubset);
                return result;
            }
            Helper(result, nullsubset, nums, 0);
            return result;
        }

        private void Helper(List<IList<int>> result, List<int> subset, int[] nums, int startIndex)
        {
            var newSubset = new List<int>(subset);
            result.Add(newSubset);
            for (var i = startIndex; i < nums.Length; i++)
            {
                newSubset.Add(nums[i]);
                Helper(result, newSubset, nums, i + 1);
                newSubset.RemoveAt(newSubset.Count() - 1); // back track to last subset
            }

        }
    }
}
