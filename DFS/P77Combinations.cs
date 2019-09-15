using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DFS
{
    class P77Combinations
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            var result = new List<IList<int>>();
            if (n == 0 || k == 0) return result;

            DFSHelper(result, new List<int>(), n, k, 1);
            return result;
        }

        private void DFSHelper(List<IList<int>> result,
                               List<int> combination,
                               int n,
                               int k,
                               int startIndex)
        {
            var newComb = new List<int>(combination);
            if (combination.Count() == k)
            {
                result.Add(newComb);
                return;
            }
            if (newComb.Count() == k + 1)
            {
                newComb.RemoveAt(0);
                result.Add(newComb);
                return;
            }

            for (var i = startIndex; i <= n; i++)
            {
                newComb.Add(i);
                DFSHelper(result, newComb, n, k, i + 1);
                newComb.RemoveAt(newComb.Count() - 1);
            }

        }
    }
}
