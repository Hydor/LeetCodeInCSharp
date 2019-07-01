

using System.Collections.Generic;

namespace LeetCode.BinarySearch
{
    class P240_Search2DMatrix2
    {
        public static bool SearchMatrix(int[,] matrix, int target)
        {
            if (matrix == null)
            {
                return false;
            }
            if (matrix[0, 0] == target) return true;
            var rowStart = 0;
            var colStart = 0;
            var rowEnd = matrix.GetLength(0) - 1;
            var colEnd = matrix.GetLength(1) - 1;
            var rowMid = 0;
            var colMid = 0;
            while (rowStart + 1 < rowEnd && colStart + 1 < colEnd)
            {
                rowMid = rowStart + (rowEnd - rowStart) / 2;
                colMid = colStart + (colEnd - colStart) / 2;
                if (matrix[rowMid, colMid] == target)
                {
                    return true;
                }
                else if (matrix[rowMid, colMid] > target)
                {
                    rowEnd = rowMid;
                    colEnd = colMid;
                }
                else
                {
                    rowStart = rowMid;
                    colStart = colMid;
                }
            }
            for (var i = 0; i <= rowEnd; i++)
            {
                if (matrix[i, colEnd] == target) return true;
            }
            for (var j = 0; j <= colEnd; j++)
            {
                if (matrix[rowEnd, j] == target) return true;
            }
            var q = new Stack<int>();
            q.

            return false;
        }
    }
}
