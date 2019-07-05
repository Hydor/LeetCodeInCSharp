using System;

namespace LeetCode.TreePro
{

    public class TreeNode
    {
         public int val;
         public TreeNode left;
         public TreeNode right;
         public TreeNode(int x) { val = x; }
    }

    public class ResultType
    {
        public bool isBalanced;
        public int height;
        public ResultType(bool b, int x) { isBalanced = b; height = x; }  //set function needed
    }
    public class P110_BalancedBinaryTree
    {
        public bool IsBalanced(TreeNode root)
        {
            return Helper(root).isBalanced;
        }

        public ResultType Helper(TreeNode root)
        {
            if (root == null)
            {
                return new ResultType(true, 0);
            }

            var left = Helper(root.left);
            var right = Helper(root.right);

            if (!left.isBalanced || !right.isBalanced) //return condition
            {
                return new ResultType(false, -1);
            }

            return new ResultType(
                Math.Abs(left.height - right.height) <= 1, 
                Math.Max(left.height, right.height) + 1 
                );

        }
    }



}
