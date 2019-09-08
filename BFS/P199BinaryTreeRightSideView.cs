using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BFS
{
    class P199BinaryTreeRightSideView
    {
        public IList<int> RightSideView(TreeNode root)
        {
            var resultList = new List<int>();
            if (root == null)
            {
                return resultList;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Any())
            {
                var size = queue.Count();
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
                    if (i == size - 1)
                    {
                        resultList.Add(currNode.val);
                    }
                }
            }
            return resultList;
        }
    }
}
