
using System.Collections.Generic;
using System.Linq;

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

        //Approach 2: Stack
        public IList<int> Postorder(TreeNode root)
        {
            var result = new List<int>();
            if (root == null) return result;
            var stack = new Stack<TreeNode>();
            var curr = root;
            stack.Push(curr);
            while (stack.Any())
            {
                curr = stack.Pop();   
                result.Insert(0, curr.val);     // Insert to first index. Cause DFS is Top-> Bottom, but Postorder is Bottom -> Top
                if (curr.left != null)
                {
                    stack.Push(curr.left);
                }
                if (curr.right != null)
                {
                    stack.Push(curr.right);
                }
            }

            return result;
        }
    }
}
