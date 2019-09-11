using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BFS
{
    class P286_WallsandGates
    {
        public class Point
        {
            public int row;
            public int col;
            public Point(int x, int y) { this.row = x; this.col = y; }
        }
        public const int INF = int.MaxValue;
        public static void WallsAndGates(int[][] rooms)
        {
            if (rooms == null || rooms.Length == 0) return;
            var row = rooms.Length;
            var col = rooms[0].Length;
            var step = 0;
            var InfCount = 0;


            // create a move array
            var deltaX = new int[] { 0, 0, 1, -1 };
            var deltaY = new int[] { 1, -1, 0, 0 };

            // BFS
            var queue = new Queue<Point>();
            // 1. put all gates into queue as Starting point
            //      and count INF numbers
            for (var i = 0; i < row; i++)
            {
                for (var j = 0; j < col; j++)
                {
                    if (rooms[i][j] == 0)
                    {
                        var p = new Point(i, j);
                        queue.Enqueue(p);
                    }
                    else if (rooms[i][j] == INF)
                    {
                        InfCount++;
                    }
                }
            }

            while (queue.Any())
            {
                step++;
                var size = queue.Count();
                for (var i = 0; i < size; i++)
                {
                    var currPoint = queue.Dequeue();
                    for (var d = 0; d < 4; d++)
                    {
                        var nextrow = currPoint.row + deltaX[d];
                        var nextcol = currPoint.col + deltaY[d];
                        if (IsInGrid(row, col, nextrow, nextcol))
                        {
                            if (rooms[nextrow][nextcol] == INF)
                            {
                                rooms[nextrow][nextcol] = step;
                                var newP = new Point(nextrow, nextcol);
                                queue.Enqueue(newP);
                                InfCount--;
                                if (InfCount == 0) return;
                            }
                        }
                    }
                }
            }
        }

       static  bool IsInGrid(int row, int col, int currrow, int currcol)
        {
            return row > currrow && col > currcol && currrow >= 0 && currcol >= 0;
        }
    }
}
