

namespace LeetCode.TreePro
{
    class P101_SymmetricTree
    {

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public bool IsSymmetric(TreeNode root)
        {

            if (root == null)
            {
                return true;
            }
            return PreorderHelper(root, root);
        }
        bool PreorderHelper(TreeNode r1, TreeNode r2)
        {
            if (r1 == null && r2 == null)
            {
                return true;
            }
            if (r1 == null || r2 == null)
            {
                return false;
            }
            return (r1.val == r2.val)
                && PreorderHelper(r1.left, r2.right)
                && PreorderHelper(r1.right, r2.left);
        }
    }
}
