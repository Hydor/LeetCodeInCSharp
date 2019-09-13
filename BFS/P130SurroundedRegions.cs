using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BFS
{
    class P130SurroundedRegions
    {

        public class Point
        {
            public int row;
            public int col;
            public Point(int x, int y) { row = x; col = y; }
        }

        public static void Solve(char[][] board)
        {
            if (board == null || board.Length == 0)
            {
                return;
            }
            var row = board.Length;
            var col = board[0].Length;

            var detalX = new int[] { 0, 0, 1, -1 };
            var detalY = new int[] { 1, -1, 0, 0 };

            var aliveList = new List<Point>();

            var queue = new Queue<Point>();
            for (var i = 0; i < row; i++)
            {
                for (var j = 0; j < col; j++)
                {
                    if (board[i][j] == 'O')
                    {

                        var isLive = false;
                        var pList = new List<Point>();
                        var p = new Point(i, j);
                        queue.Enqueue(p);
                        pList.Add(p);
                        while (queue.Any())
                        {
                            var currPoint = queue.Dequeue();
                            board[currPoint.row][currPoint.col] = '-';  // take this point to another mark
                            for (var d = 0; d < 4; d++)
                            {
                                var currr = currPoint.row + detalX[d];
                                var currc = currPoint.col + detalY[d];
                                if (IsInBorder(row, col, currr, currc))
                                {
                                    if (board[currr][currc] == 'O')
                                    {
                                        var newp = new Point(currr, currc);
                                        queue.Enqueue(newp);
                                        pList.Add(newp);
                                    }
                                }
                                else
                                {
                                    isLive = true;
                                }
                            }
                        }

                        // after one entail queue, if is live then turn - to O, if dead turn to X

                        if (isLive)
                        {
                            foreach (var item in pList)
                            {
                                aliveList.Add(item);
                            }
                        }
                        else
                        {
                            foreach (var item in pList)
                            {
                                board[item.row][item.col] = 'X';
                            }
                        }

                    }
                }
            }


            foreach (var item in aliveList)
            {
                board[item.row][item.col] = 'O';
            }
        }

        public static bool IsInBorder(int row, int col, int currr, int currc)
        {
            return row > currr && col > currc && currr >= 0 && currc >= 0;
        }
    }
}
