using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TreePro
{
    class P111_MinimumDepthBinaryTree
    {
        public int MinDepths;
        public int MinDepth(TreeNode root)
        {
            MinDepths = int.MaxValue;
            if (root == null)
            {
                return 0;
            }
            TraversalHelper(root, 1);
            return MinDepths;
        }
        void TraversalHelper(TreeNode root, int depth)
        {
            if (root == null)
            {
                return;
            }
            if (root.left == null && root.right == null)
            {
                MinDepths = Math.Min(MinDepths, depth);
            }
            TraversalHelper(root.left, depth + 1);
            TraversalHelper(root.right, depth + 1);
        }
    }
}
