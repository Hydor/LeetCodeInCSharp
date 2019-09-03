

namespace LeetCode.TreePro
{
    class P112PathSum
    {
        // 
        public bool isFind;
        public bool HasPathSum(TreeNode root, int sum)
        {
            isFind = false;
            if (root == null)
            {
                return false;
            }
            var currsum = 0;
            TraversalHelper(root, sum, currsum);
            return isFind;

        }
        void TraversalHelper(TreeNode root, int target, int currentSum)
        {
            if (root == null)
            {
                return;
            }

            currentSum += root.val;
            if (root.left == null && root.right == null)
            {
                if (currentSum == target)
                {
                    isFind = true;
                }
                return;
            }
            TraversalHelper(root.left, target, currentSum);
            TraversalHelper(root.right, target, currentSum);
        }

        // Approach 2 Actrually, It's same method, but this one is smarter and simpler
        public bool HasPathSum2(TreeNode root, int sum)
        {
            if (root == null)
            {
                return false;
            }

            sum -= root.val;
            if (root.left == null && root.right == null)
            {
                return (sum == 0);
            }

            return HasPathSum(root.left, sum) || HasPathSum(root.right, sum);
        }
    }
}
