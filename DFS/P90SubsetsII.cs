using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DFS
{
    class P90SubsetsII
    {
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            var result = new List<IList<int>>();
            if (nums == null) return result;

            if (nums.Length == 0)
            {
                result.Add(new List<int>());
                return result;
            }

            Array.Sort(nums);  // sort array first
            var set = new HashSet<string>();     // use Hashset to dedup
            DFSHelper(nums, result, new List<int>(), 0, set, "");

            return result;
        }

        private void DFSHelper(int[] nums,
                            List<IList<int>> result,
                            List<int> tempList,
                            int startIndex, HashSet<string> set, string s)
        {
            var newTempList = new List<int>(tempList);
            if (!set.Contains(s))
            {
                set.Add(s);
                result.Add(newTempList);
            }


            for (var i = startIndex; i < nums.Length; i++)
            {
                newTempList.Add(nums[i]);
                s += nums[i];
                DFSHelper(nums, result, newTempList, i + 1, set, s);

                s = newTempList[newTempList.Count() - 1] < 0
                    ? s.Remove(s.Length - 2, 2)
                    : s.Remove(s.Length - 1, 1);
                newTempList.RemoveAt(newTempList.Count() - 1);
            }

        }

    }
}
