using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TreePro
{
    class P226_InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return root;
            }
            var left = InvertTree(root.left);
            var right = InvertTree(root.right);
            var temp = new TreeNode(0);
            temp = root.left;
            root.left = root.right;
            root.right = temp;
            return root;
        }
    }
}
