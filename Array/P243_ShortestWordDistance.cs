using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class P243_ShortestWordDistance
    {
        public static int ShortestDistance(string[] words, string word1, string word2)
        { 
            var countArr = new int[] { 1000, 1000, 1000, 1000, 1000 , 1000, 1000, 1000, 1000, 1000 };
            var j = 0;
            var point1 = -1;
            var point2 = -1;
            for (int i=0;i< words.Count(); i++)
            {
                if (words[i] == word1) {
                    point1 = i;
                    if (point1 != -1 && point2 != -1) { countArr[j] = point1 - point2 ;  j++; }
                }
                else if (words[i] == word2) {
                    point2 = i;
                    if (point1 != -1 && point2 != -1) { countArr[j] = point2 - point1; j++; }
                }
            }


            return countArr.Min();
        }

    }
}
