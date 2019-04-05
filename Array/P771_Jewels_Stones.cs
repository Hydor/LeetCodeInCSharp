using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Array
{
    class P771_Jewels_Stones
    {


        // Dictionary    100%   14.6%
        public static int NumJewelsInStones(string J, string S)
        {
            var count = 0;
            var jewDict = new Dictionary<char, int>();
            var jArr = J.ToCharArray();
            var sArr = S.ToCharArray();
            
            for (var i = 0; i < jArr.Count(); i++)
            {
                jewDict.Add(jArr[i], 0);
            }
            foreach (var i in sArr)
            {
                if (jewDict.ContainsKey(i))
                {
                    var oldvalue = 0;
                    jewDict.TryGetValue(i, out oldvalue);
                    jewDict[i] = oldvalue + 1;
                }               
            }
            for (var i = 0; i < jArr.Count(); i++)
            {
                count += jewDict[jArr[i]];
            }
            return count;
        }
    }
}
