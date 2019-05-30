using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    class P1054_DistantBarcodes
    {
        public static int[] RearrangeBarcodes(int[] barcodes)
        {
            var time = 5;
            var temp = 0;
            var count = 0;
            while (time > 0)
            {
                count = 0;
                for (var i = 1; i < barcodes.Count() - 1; i++)
                {
                    if (barcodes[i - 1] == barcodes[i]) { temp = barcodes[i]; barcodes[i] = barcodes[i + 1]; barcodes[i + 1] = temp; count++; }
                }
                if (count == 0) return barcodes;
                time--;
            }

            var res= new int[barcodes.Count()];
            var index = 0;
            var dic = new Dictionary<int, int>();
            var bu = 0;
            for (var i = 0; i < barcodes.Count(); i++)
            {
                if (dic.ContainsKey(barcodes[i])) { dic[barcodes[i]] += 1 ; }
                else
                {
                    dic.Add(barcodes[i], 1);                    
                }
            }
            while (index < barcodes.Count())
            {
                var max = dic.Values.Max();
                if (max == 0) break;               
                var firstKey = dic.FirstOrDefault(q => q.Value == max).Key;
                if (index > 0 && res[index - 1] == firstKey)
                {
                    for(;bu<barcodes.Count(); bu++)
                    {
                        if (barcodes[bu] != firstKey && dic[barcodes[bu]]>0) {
                            res[index++] = barcodes[bu];
                            dic[barcodes[bu] ] -= 1;
                            break;
                        }
                    }
                }
                else { 
                res[index++] = firstKey;
                dic[firstKey] -= 1;
                }

            }
            return res;

        }

       
        }
}
