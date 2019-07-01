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

                var a = new int[] {1, 2, 3, 4 ,5};
                var arr2D = new int[,] { { 1, 4, 7, 11,15 }, { 2, 5, 8, 12,19 }, { 3, 6, 9, 16 ,22}, { 10, 13, 14, 17 ,24}, { 18, 21, 23, 26 ,31} };
                var strarr = new string[] { "Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.", "Art", "is", "everything", "else", "we", "do" };
                
                Console.WriteLine(BinarySearch.P240_Search2DMatrix2.SearchMatrix(arr2D, 15));
                var str = Console.ReadLine();
                var str2 = Console.ReadLine();
            }
        }




        


    }
}
