using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DFS
{
    class P46Permutations
    {

        // DFS  +  Hashset           Memory Usage: 31.2 MB
        // DFS  +  bool[] visited    Memory Usage: 31.1 MB
        // And the time cost is same


        public IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums == null) return result;
            var newList = new List<int>();
            if (nums.Length == 0)
            {
                result.Add(newList);
                return result;
            }

            // Since the input numbers are distinct and result set no need ordered
            // So we DO NOT need startIndex 
            // And DO NOT need sort the array first

            DFSHelper(result, newList, nums, new HashSet<int>());
            return result;
        }

        private void DFSHelper(List<IList<int>> result,
                               IList<int> tempList,
                               int[] nums,
                               HashSet<int> hashset)
        {
            var temp = new List<int>(tempList);
            if (temp.Count() == nums.Length)
            {
                result.Add(temp);
                return;
            }

            for (var i = 0; i < nums.Length; i++)
            {
                if (!hashset.Contains(nums[i]))
                {
                    hashset.Add(nums[i]);
                    temp.Add(nums[i]);
                    DFSHelper(result, temp, nums, hashset);
                    hashset.Remove(nums[i]);         // remember to remove from the Hashset
                    temp.RemoveAt(temp.Count() - 1);
                }
            }
        }
    }
}
