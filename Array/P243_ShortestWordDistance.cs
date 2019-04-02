using System;
using System.Linq;

namespace LeetCode
{
    class P243_ShortestWordDistance
    {

        // two pointer     92%     50%
        public int ShortestDistance(string[] words, string word1, string word2)
        {
            var countArr = new int[] { 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000, 1000 };
            var j = 0;
            var point1 = -1;
            var point2 = -1;
            for (int i = 0; i < words.Count(); i++)
            {
                if (words[i] == word1)
                {
                    point1 = i;
                    if (point1 != -1 && point2 != -1) { countArr[j] = point1 - point2; j++; }
                }
                else if (words[i] == word2)
                {
                    point2 = i;
                    if (point1 != -1 && point2 != -1) { countArr[j] = point2 - point1; j++; }
                }
            }

            return countArr.Min();
        }




        // two pointer     60%     50%    slower
        public static int ShortestDistance2(string[] words, string word1, string word2)
        { 
            var countArr =10000;
            var point1 = -1;
            var point2 = -1;
            for (int i=0;i< words.Count(); i++)
            {
                if (words[i] == word1) {
                    point1 = i;
                    if (point1 != -1 && point2 != -1) { countArr = Math.Min(countArr, point1 - point2) ;  }
                }
                else if (words[i] == word2) {
                    point2 = i;
                    if (point1 != -1 && point2 != -1) { countArr  = Math.Min(countArr, point2 - point1); }
                }
            }

            return countArr;
        }

    }
}
