
namespace LeetCode.TreePro
{
    /**
    * Definition for a binary tree node.
    * public class TreeNode {
    *     public int val;
    *     public TreeNode left;
    *     public TreeNode right;
    *     public TreeNode(int x) { val = x; }
    * }
    */

    class P236_LCA
    {

        // Divide & Conquer
        // there are 4 conditions
        // 1. left is not null (find something) and right is not null  -> return root.  root is Common Ancestor
        // 2. left is not null    -> return left  
        // 3. right is not null    -> return right  
        // 4. both null (find nothing)  -> return null

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || root == p || root == q)
            {
                return root;
            }

            var left = LowestCommonAncestor(root.left, p, q);
            var right = LowestCommonAncestor(root.right, p, q);

            if (left != null && right != null)
            {
                return root;
            }

            if (left != null)
            {
                return left;
            }
            if (right != null)
            {
                return right;
            }
            else
            {
                return null;
            }
        }

    }

}
