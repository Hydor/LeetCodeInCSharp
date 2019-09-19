using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.DFS
{
    class P47PermutationsII
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums == null) return result;

            if (nums.Length == 0)
            {
                result.Add(new List<int>());
                return result;
            }

            System.Array.Sort(nums);

            var visited = new bool[nums.Length];
            DFSHelper(nums, result, new List<int>(), visited);
            return result;
        }


        private void DFSHelper(int[] nums,
                               List<IList<int>> result,
                               List<int> temp,
                               bool[] visited)
        {
            var tempList = new List<int>(temp);
            if (tempList.Count() == nums.Length)
            {
                result.Add(tempList);
                return;
            }
            for (var i = 0; i < nums.Length; i++)
            {
                if (visited[i] == true) continue;
                if (i >= 1 && nums[i] == nums[i - 1] && visited[i - 1] == true) continue;
                tempList.Add(nums[i]);
                visited[i] = true;
                DFSHelper(nums, result, tempList, visited);
                tempList.RemoveAt(tempList.Count() - 1);
                visited[i] = false;
            }
        }

    }
}
