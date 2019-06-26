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
                var strarr = new string[] { "Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.", "Art", "is", "everything", "else", "we", "do" };
                
                Console.WriteLine(BinarySearch.P35_FindInsertIndex.SearchInsert(a,1));
                var str = Console.ReadLine();
                var str2 = Console.ReadLine();
            }
        }




        


    }
}
