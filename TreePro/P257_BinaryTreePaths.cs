using System.Collections.Generic;

namespace LeetCode.TreePro
{
    class P257_BinaryTreePaths
    {
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            var res = new List<string>();
            if (root == null)
            {
                return res;
            }
            var pathStr = "";
            TraversalHelper(root, res, pathStr);
            return res;

        }
        void TraversalHelper(TreeNode root, List<string> res, string pathStr)
        {
            if (root == null)
            {
                return;
            }
            if (pathStr != "")
            {
                pathStr += "->";
            }
            pathStr += root.val.ToString();
            if (root.left == null && root.right == null)
            {
                res.Add(pathStr);
                return;
            }
            if (root.left != null)
            {
                TraversalHelper(root.left, res, pathStr);
            }
            if (root.right != null)
            {
                TraversalHelper(root.right, res, pathStr);
            }

        }
    }
}
