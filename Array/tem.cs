using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    class tem
    {
        public static int LongestSubsequence(int[] arr, int difference)
        {
            var maxcount = 0;
            if (arr == null || arr.Count() == 0) return maxcount;
           

            var dict = new Dictionary<int, List<int>>();
            for (var i = 0; i < arr.Length; i++)
            {
                if (!dict.ContainsKey(arr[i]))
                {
                    var nl = new List<int>();
                    nl.Add(i);
                    dict.Add(arr[i], nl);
                }
                else dict[arr[i]].Add(i);

            }

            var isInList = true;
            foreach (var item in dict)
            {
                isInList = true;
                var index = item.Value.Min();
                var count = 1;
                var next = item.Key + difference;
                while (dict.ContainsKey(next) && isInList)
                {
                    isInList = false;
                    foreach (var il in dict[next])
                    {
                        if (il > index)
                        {
                            count++;
                            index = il;
                            next += difference;
                            isInList = true;
                            break;
                        }
                    }

                }
                maxcount = maxcount > count ? maxcount : count;
            }
            return maxcount;

        }
    }
}
