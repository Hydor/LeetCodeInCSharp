
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.BFS
{
    class P107
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            var result = new List<IList<int>>();
            if (root == null)
            {
                return result;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Any())
            {
                var size = queue.Count();
                var currList = new List<int>();

                for (var i = 0; i < size; i++)
                {
                    var currNode = queue.Dequeue();
                    if (currNode.left != null)
                    {
                        queue.Enqueue(currNode.left);
                    }
                    if (currNode.right != null)
                    {
                        queue.Enqueue(currNode.right);
                    }
                    currList.Add(currNode.val);
                }
                result.Add(currList);
            }
            result.Reverse();
            return result;
        }
    }
}
