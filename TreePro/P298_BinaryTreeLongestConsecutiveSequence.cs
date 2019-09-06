using System;

namespace LeetCode.TreePro
{
    class P298_BinaryTreeLongestConsecutiveSequence
    {
        public int MAXCOUNT;
        public int LongestConsecutive(TreeNode root)
        {
            MAXCOUNT = 0;
            if (root == null)
            {
                return MAXCOUNT;
            }

            TraHelper(root, int.MinValue, 0);
            return MAXCOUNT;
        }
        void TraHelper(TreeNode root, int lastval, int count)
        {
            if (root == null)
            {
                return;
            }

            if (lastval == int.MinValue)
            {
                count = 1;
            }
            else
            {
                if (lastval + 1 == root.val)
                {
                    count += 1;
                }
                else
                {

                    count = 1;
                }
            }
            MAXCOUNT = Math.Max(MAXCOUNT, count);
            lastval = root.val;
            TraHelper(root.left, lastval, count);
            TraHelper(root.right, lastval, count);

        }
    }
}
