using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BFS
{
    class P200_NumberofIslands
    {
        public class Point
        {
            public int row;
            public int col;
            public Point(int x, int y) { row = x; col = y; }
        }
        public static int NumIslands(char[][] grid)
        {
            var num = 0;
            if (grid == null || grid.Length == 0)
            {
                return num;
            }

            int row = grid.Length;
            int col = grid[0].Length;

            var deltaX = new int[] { 0, 0, 1, -1 };
            var deltaY = new int[] { 1, -1, 0, 0 };

            for (var r = 0; r < row; r++)
            {
                for (var c = 0; c < col; c++)
                {
                    if (grid[r][c] == '1')
                    {
                        grid[r][c] = '0';
                        num++;
                        var queue = new Queue<Point>();
                        var p = new Point(r, c);
                        queue.Enqueue(p);
                        while (queue.Any())
                        {
                            var currpoint = queue.Dequeue();
                            for (var i = 0; i < 4; i++)
                            {
                                var nextrow = currpoint.row + deltaX[i];
                                var nextcol = currpoint.col + deltaY[i];
                                if (InBorder(row, col, nextrow, nextcol))
                                {
                                    if (grid[nextrow][nextcol] == '1')
                                    {
                                        grid[nextrow][nextcol] = '0';
                                        var newP = new Point(nextrow, nextcol);
                                        queue.Enqueue(newP);
                                    }
                                }
                            }
                        }
                    }

                }
            }

            return num;
        }

        static bool InBorder(int row, int col, int currrow, int currcol)
        {
            return (row > currrow) && (col > currcol) && currcol >= 0 && currrow>= 0;
        }
    }
}
