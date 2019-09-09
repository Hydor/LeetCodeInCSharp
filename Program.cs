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

                var ab = new int[] { 7, 9, 1, 2, 6, 3, 4, 5 };
                var arr2D = new int[,] { { 1, 4, 7, 11,15 }, { 2, 5, 8, 12,19 }, { 3, 6, 9, 16 ,22}, { 10, 13, 14, 17 ,24}, { 18, 21, 23, 26 ,31} };
                var strarr = new string[] { "Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.", "Art", "is", "everything", "else", "we", "do" };
                var str = new string[] {"fasdfawx", "fefsfasdwf"};
                Console.WriteLine(Convert.ToChar(97));
                //var node = new TreePro.P101_SymmetricTree.TreeNode(1);
                // node.left = new TreePro.P101_SymmetricTree.TreeNode(2);
                // node.right = new TreePro.P101_SymmetricTree.TreeNode(2);
                //  node.left.left = new TreePro.P101_SymmetricTree.TreeNode(3);

                Console.WriteLine(TopoSorting.P269_AlienDictionary.AlienOrder(str));

                //foreach (var i in ab)
                //{
                //    Console.WriteLine(i);
                //}
              
                var str2 = Console.ReadLine();
            }
        }




        


    }
}
