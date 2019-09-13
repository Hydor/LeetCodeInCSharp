using LeetCode.Array;
using System;
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

                var a = new int[] { 1, 2, 3, 4, 5 };

                var ab = new int[] { 7, 9, 1, 2, 6, 3, 4, 5 };
                var arr2D = new int[,] { { 1, 4, 7, 11, 15 }, { 2, 5, 8, 12, 19 }, { 3, 6, 9, 16, 22 }, { 10, 13, 14, 17, 24 }, { 18, 21, 23, 26, 31 } };
                
                var strarr = new string[] {"OOOO", "XOOX", "XXOX", "XXXO"};

                var c = new char[4][];
                for (var i = 0; i < 4; i++)
                {
                    c[i] = strarr[i].ToCharArray();
                }

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


                //Console.WriteLine(BFS.P130SurroundedRegions.Solve(c));
                BFS.P130SurroundedRegions.Solve(c);
              
                var str2 = Console.ReadLine();
            }

        }




        


    }
}
