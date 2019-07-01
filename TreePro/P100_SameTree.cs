using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TreePro
{

    class P100_SameTree
    {
        public class TreeNode {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }


        // Recursive 
        // Bug 1: isSame should be GLOBAL variable, cannot passed as parameters, 
        // Bug 2: p & q both null or one of them, should be aware
        public bool isSame;
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            if (p == null || q == null)
            {
                return false;
            }
            isSame = true;
            TraverseHelper(p, q);
            return isSame;
        }
        void TraverseHelper(TreeNode p, TreeNode q)
        {
            if (!isSame || (q == null && p == null))
            {
                return;
            }

            if (q == null || p == null)
            {
                isSame = false;
                return;
            }
            if (p.val != q.val)
            {
                isSame = false;

                return;
            }
            TraverseHelper(p.left, q.left);
            TraverseHelper(p.right, q.right);

        }
    }
}
