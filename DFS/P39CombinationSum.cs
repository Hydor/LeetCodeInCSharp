using System.Collections.Generic;
using System.Linq;

namespace LeetCode.DFS
{
    class P39CombinationSum
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            // 1. check the input parameters
            var result = new List<IList<int>>();
            if (candidates == null || candidates.Length == 0)
            {
                return result;
            }

            var sub = new List<int>();
            if (target == 0)
            {
                result.Add(sub);
                return result;

            }
            // 2. Sort array
            System.Array.Sort(candidates);

            // 3. DFS Helper method
            Helper(candidates, target, result, sub, 0);

            return result;
        }


        
        void Helper(int[] candidates,
                    int target,
                    List<IList<int>> result,
                    List<int> subList,
                    int startIndex)
        {
            // hard copy 
            var newSubList = new List<int>(subList);

            // from the startIndex to avoid duplicates
            for (var i = startIndex; i < candidates.Length; i++)
            {
                newSubList.Add(candidates[i]);
                if (newSubList.Sum() == target)
                {
                    result.Add(newSubList);
                    return;
                }
                else if (newSubList.Sum() >= target) //stop add number when over target
                {
                    return;
                }
                Helper(candidates, target, result, newSubList, i);
                newSubList.RemoveAt(newSubList.Count() - 1); //remove the last number to back track the front subList
            }
        }
    }
}
