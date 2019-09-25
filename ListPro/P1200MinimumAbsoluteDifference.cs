using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ListPro
{
    class P1200MinimumAbsoluteDifference
    {
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            var result = new List<IList<int>>();
            if (arr == null) return result;
            if (arr.Length <= 1)
            {
                result.Add(new List<int>());
                return result;
            }
            System.Array.Sort(arr);
            var dict = new Dictionary<int, List<IList<int>>>();
            var min = int.MaxValue;


            for (var i = 1; i < arr.Length; i++)
            {
                var l = new List<int>();
                var difference = arr[i] - arr[i - 1];
                if (difference > min) continue;
                min = difference;
                l.Add(arr[i - 1]);
                l.Add(arr[i]);
                if (dict.ContainsKey(difference))
                {
                    dict[difference].Add(l);
                }
                else
                {
                    var pairlist = new List<IList<int>>();
                    pairlist.Add(l);
                    dict.Add(difference, pairlist);
                }


            }
            var minresult = dict[min];
            return minresult;
        }
    }
}
