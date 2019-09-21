using LeetCode.Array;
using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //var number1 = Convert.ToInt32(Console.ReadLine());
                //var number2 = Convert.ToInt32(Console.ReadLine());

                var a = new int[] { 1, 3 };

                var ab = new int[] { 7, 9, 1, 2, 6, 3, 4, 5 };
                var arr2D = new int[,] { { 1, 4, 7, 11, 15 }, { 2, 5, 8, 12, 19 }, { 3, 6, 9, 16, 22 }, { 10, 13, 14, 17, 24 }, { 18, 21, 23, 26, 31 } };

                var ifj = new string[] { "83..7....", "6..195...", ".98....6.", "8...6...3", "4..8.3..1", "7...2...6", ".6....28.", "...419..5", "....8..79" };
                var charf = new char[9][];
                for (var i = 0; i < 9; i++)
                {
                    charf[i] = ifj[i].ToCharArray();
                }


                HashMapPro.P36ValidSudoku.IsValidSudoku(charf);

                var strarr = new string[] { "abcd" };

          
                //var c = strarr[1].ToCharArray();
                var ins = new int[4][];
                ins[0] = new int[4];
                ins[2] = new int[4];
                ins[1] = new int[4];
                ins[3] = new int[4];

               

                ins[0][0] = 2147483647;
                ins[0][1] = -1;
                ins[0][2] = 0;
                ins[0][3] = 2147483647;

                ins[1][0] = 2147483647;
                ins[1][1] = 2147483647;
                ins[1][2] = 2147483647;
                ins[1][3] = -1;

                ins[2][0] = 2147483647;
                ins[2][1] = -1;
                ins[2][2] = 2147483647;
                ins[2][3] = -1;

                ins[3][0] = 0;
                ins[3][1] = -1;
                ins[3][2] = 2147483647;
                ins[3][3] = 2147483647;


                //Console.WriteLine(StrPro.P3LongestSubstringWithoutRepeatinCharacters.LengthOfLongestSubstring("abcdaqa"));

                var l1 = new List<BFS.P133CloneGraph.Node>();
                var l2 = new List<BFS.P133CloneGraph.Node>();
                var l3 = new List<BFS.P133CloneGraph.Node>();
                var l4 = new List<BFS.P133CloneGraph.Node>();

                var node1 = new BFS.P133CloneGraph.Node(1, l1);
                var node2 = new BFS.P133CloneGraph.Node(2, l2);
                var node3 = new BFS.P133CloneGraph.Node(3, l3);
                var node4 = new BFS.P133CloneGraph.Node(4, l4);

                l1.Add(node2);
                l1.Add(node4);
                l2.Add(node1);
                l2.Add(node3);
                l3.Add(node2);
                l3.Add(node4);
                l4.Add(node1);
                l4.Add(node3);


                //BFS.P133CloneGraph.CloneGraph(node1);

                var str2 = Console.ReadLine();
            }

        }




        


    }
}
