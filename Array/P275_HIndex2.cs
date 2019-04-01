using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    class P275_HIndex2
    {
        public static int HIndex(int[] citations)
        {
            int i = 0;
            while (i < citations.Count() && citations[citations.Count() - 1 - i] > i)
            {
                i++;
            }
            return i;
        }
    }
}
