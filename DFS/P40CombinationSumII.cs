using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DFS
{
    class P40CombinationSumII
    {
        public static IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            // check input
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
            // sort array
            System.Array.Sort(candidates);

            // DFS
            Helper(candidates, target, result, sub, 0);

            return result;
        }

        private static void Helper(int[] candidates,
                            int restSum,
                            List<IList<int>> result,
                            List<int> subList,
                            int startIndex)
        {
            //hard copy subList
            var newSubList = new List<int>(subList);


            for (var i = startIndex; i < candidates.Length && candidates[i] <= restSum; i++)
            {

                if (i > startIndex && candidates[i] == candidates[i - 1])
                    continue;
                newSubList.Add(candidates[i]);
                if (restSum - candidates[i] == 0)
                {
                    result.Add(newSubList);
                    return;
                }
                if (restSum - candidates[i] < 0)
                {
                    return;
                }

                Helper(candidates, restSum - candidates[i], result, newSubList, i + 1);
                newSubList.Remove(newSubList.Last());
            }
        }
    }
}

