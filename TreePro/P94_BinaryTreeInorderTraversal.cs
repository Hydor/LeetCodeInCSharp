using System.Collections.Generic;
using System.Linq;

namespace LeetCode.TreePro
{
    class P94_BinaryTreeInorderTraversal
    { 
     public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

        // Approach1： Recursive
        public IList<int> InorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            if (root == null)
            {
                return result;
            }
            InorderTraversalHelper(root, result);

            return result;
        }
        void InorderTraversalHelper(TreeNode root, List<int> list)
        {
            if (root == null)
            {
                return;
            }
            InorderTraversalHelper(root.left, list);
            list.Add(root.val);
            InorderTraversalHelper(root.right, list);
        }


        // Approach 2: Stack
        public IList<int> InorderTraversal2(TreeNode root)
        {
            var result = new List<int>();
            if (root == null) return result;
            var stack = new Stack<TreeNode>();
            var curr = root;

            while (curr != null || stack.Any())
            {
                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }
                curr = stack.Pop();
                result.Add(curr.val);
                curr = curr.right;
            }

            return result;
        }


    }
}
