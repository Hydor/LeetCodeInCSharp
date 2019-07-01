using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TreePro
{
    class P145_BinaryTreePostorderTraversal
    {


        public class TreeNode
        {
             public int val;
             public TreeNode left;
             public TreeNode right;
             public TreeNode(int x) { val = x; }
         }

        // Recursive
        public IList<int> PostorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            if (root == null) return result;
            PostorderTraversalHelper(root, result);
            return result;
        }

        void PostorderTraversalHelper(TreeNode root, List<int> list)
        {
            if (root == null)
            {
                return;
            }
            PostorderTraversalHelper(root.left, list);
            PostorderTraversalHelper(root.right, list);
            list.Add(root.val);
        }
    }
}
