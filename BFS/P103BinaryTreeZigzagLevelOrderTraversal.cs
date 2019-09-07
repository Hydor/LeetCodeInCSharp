using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BFS
{
    class P103BinaryTreeZigzagLevelOrderTraversal
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            var resultList = new List<IList<int>>();
            if (root == null)
            {
                return resultList;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var leftToRight = false;
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

                leftToRight = !leftToRight;
                if (!leftToRight)
                {
                    currList.Reverse();
                }
                resultList.Add(currList);

            }
            return resultList;
        }
    }
}
