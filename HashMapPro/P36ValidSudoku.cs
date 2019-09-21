using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HashMapPro
{
    class P36ValidSudoku
    {
        public static bool IsValidSudoku(char[][] board)
        {
            if (board == null || board.Length != 9 || board[0].Length != 9) return false;

            var rowDict = new Dictionary<int, HashSet<int>>();
            var colDict = new Dictionary<int, HashSet<int>>();
            var subDict = new Dictionary<int, HashSet<int>>();
            var subIndex = 0;
            for (var i = 0; i < 9; i++)
            {
                for (var j = 0; j < 9; j++)
                {
                    if (board[i][j] == '.') continue;

                    subIndex = GetSubIndex(i, j);
                    if (!IsValid(board[i][j], i, rowDict)
                         || !IsValid(board[i][j], j, colDict)
                         || !IsValid(board[i][j], subIndex, subDict)
                      )
                        return false;
                }
            }
            return true;
        }


        // sub index
        // 0  1  2
        // 3  4  5
        // 6  7  8
        private static int GetSubIndex(int i, int j)
        {
            return (i / 3) * 3 + j / 3;
        }

        private static bool IsValid(int number, int index, Dictionary<int, HashSet<int>> dict)
        {
            if (!dict.ContainsKey(index))
            {
                dict.Add(index, new HashSet<int>());
            }
            else if (dict[index].Contains(number))
            {
                return false;
            }
            dict[index].Add(number);
            return true;
        }


    }
}
