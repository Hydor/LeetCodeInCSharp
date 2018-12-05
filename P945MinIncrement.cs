using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class P945MinIncrement
    {
        //945. Minimum Increment to Make Array Unique
        //Given an array of integers A, a move consists of choosing any A[i], and incrementing it by 1.
        // Return the least number of moves to make every value in A unique.

        //   Example :
        
        //      Input: [3,2,1,2,1,7]
        //      Output: 6
        //  Explanation:  After 6 moves, the array could be[3, 4, 1, 2, 5, 7].
        //  It can be shown with 5 or less moves that it is impossible for the array to have all unique values.

        public static int MinIncrementForUnique(int[] A)
        {
            int[] a= new int[80001];
            a.Initialize();
            var incrementCount = 0;
            var repeatNumber = 0;
            foreach (var i in A){ a[i]++; }

            for (var j = 0; j < a.Length; j++)
            {
                if (a[j] > 1)
                {
                    repeatNumber = repeatNumber + a[j] - 1;
                    incrementCount = incrementCount - j * (a[j] - 1); 
                }
                else if (a[j]==0 && repeatNumber >0)
                {
                    repeatNumber--;
                    incrementCount = incrementCount + j;
                }
            }
            return incrementCount;
        }
    }
}
