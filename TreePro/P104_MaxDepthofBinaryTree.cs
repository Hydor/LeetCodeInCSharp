using System;

namespace LeetCode.TreePro
{
    class P104_MaxDepthofBinaryTree
    {
        public class TreeNode
        {
             public int val;
             public TreeNode left;
             public TreeNode right;
             public TreeNode(int x) { val = x; }
         }
        // Divide & Conquer
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            var left = MaxDepth(root.left);
            var right = MaxDepth(root.right);
            return Math.Max(left, right) + 1;
        }


        public int maxDeepth;
        // Recursive 
        public int MaxDepth2(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            maxDeepth = 0;

            MaxDepthHelper(root, 1);

            return maxDeepth;
        }

        void MaxDepthHelper(TreeNode root, int deepth)
        {
            if (root == null) { return; }

            maxDeepth = deepth > maxDeepth ? deepth : maxDeepth;
            MaxDepthHelper(root.left, deepth + 1);
            MaxDepthHelper(root.right, deepth + 1);
        }

    }
}
