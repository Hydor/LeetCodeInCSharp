using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    class P977_SquaresSortedArray
    {
        public int[] SortedSquares(int[] A)
        {
            var res = new int[A.Length];
            if (A == null)
            {
                return res;
            }
            var index = A.Length - 1;
            var leftPointer = 0;
            var rightPointer = A.Length - 1;
            var leftSquare = 0;
            var rightSquare = 0;
            while (leftPointer <= rightPointer)
            {
                leftSquare = A[leftPointer] * A[leftPointer];
                rightSquare = A[rightPointer] * A[rightPointer];
                if (leftSquare >= rightSquare)
                {
                    res[index--] = leftSquare;
                    leftPointer++;
                }
                else
                {
                    res[index--] = rightSquare;
                    rightPointer--;
                }
            }
            return res;
        }
    }
}
