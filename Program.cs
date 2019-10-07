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

                var a = new int[] { 4, 12, 10, 0, -2, 7, -8, 9, -9, -12, -12, 8, 8};
                 
                var arr2D = new int[,] { { 1, 4, 7, 11, 15 }, { 2, 5, 8, 12, 19 }, { 3, 6, 9, 16, 22 }, { 10, 13, 14, 17, 24 }, { 18, 21, 23, 26, 31 } };

                var ifj = new string[] { "a/*/b//*c", "blank", "d//*e/*/f" };
                var charf = new char[9][];
                //for (var i = 0; i < 9; i++)
                //{
                //    charf[i] = ifj[i].ToCharArray();
                //}

                var ll = new List<int>() { 0, 1 };

                var lll = new List<int>() { 1,2 };
                var d = new List<IList<int>>();
                d.Add(ll);
                d.Add(lll);

                StrPro.PSmallestStringWithSwaps.SmallestStringWithSwaps("cba",d);

                var strarr = new string[] { "abcd" };



                var l1 = new ListPro.ListNode(1);
                var l2 = new ListPro.ListNode(2);
                var l3 = new ListPro.ListNode(3);
                var l4 = new ListPro.ListNode(4);
                var l5 = new ListPro.ListNode(5);
                l1.next = l2;
                l2.next = l3; 
                l3.next = l4; 
                l4.next = l5;
                l5.next = null;

                Console.WriteLine(ListPro.P92_ReverseLinkedListII.ReverseBetween(l1, 2,4));







                //var l1 = new List<BFS.P133CloneGraph.Node>();
                //var l2 = new List<BFS.P133CloneGraph.Node>();
                //var l3 = new List<BFS.P133CloneGraph.Node>();
                //var l4 = new List<BFS.P133CloneGraph.Node>();

                //var node1 = new BFS.P133CloneGraph.Node(1, l1);
                //var node2 = new BFS.P133CloneGraph.Node(2, l2);
                //var node3 = new BFS.P133CloneGraph.Node(3, l3);
                //var node4 = new BFS.P133CloneGraph.Node(4, l4);

                //l1.Add(node2);
                //l1.Add(node4);
                //l2.Add(node1);
                //l2.Add(node3);
                //l3.Add(node2);
                //l3.Add(node4);
                //l4.Add(node1);
                //l4.Add(node3);

                //var c = strarr[1].ToCharArray();
                //var ins = new int[4][];
                //ins[0] = new int[4];
                //ins[2] = new int[4];
                //ins[1] = new int[4];
                //ins[3] = new int[4];

               

                //ins[0][0] = 2147483647;
                //ins[0][1] = -1;
                //ins[0][2] = 0;
                //ins[0][3] = 2147483647;

                //ins[1][0] = 2147483647;
                //ins[1][1] = 2147483647;
                //ins[1][2] = 2147483647;
                //ins[1][3] = -1;

                //ins[2][0] = 2147483647;
                //ins[2][1] = -1;
                //ins[2][2] = 2147483647;
                //ins[2][3] = -1;

                //ins[3][0] = 0;
                //ins[3][1] = -1;
                //ins[3][2] = 2147483647;
                //ins[3][3] = 2147483647;

                //BFS.P133CloneGraph.CloneGraph(node1);

                var str2 = Console.ReadLine();
            }

        }




        


    }
}
