using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BFS
{
    class P133CloneGraph
    {
        public class Node
        {
            public int val;
            public IList<Node> neighbors;

            public Node() { }
            public Node(int _val, IList<Node> _neighbors)
            {
                val = _val;
                neighbors = _neighbors;
            }
        }
            public static Node CloneGraph(Node node)
            {

                if (node == null) return new Node();
                var hashset = new HashSet<int>();

                var result = new Node(node.val, new List<Node>());
                var queue = new Queue<Node>();
                queue.Enqueue(node);


            //dict
            var isFirstNode = true;
                while (queue.Any())
                {
                    var size = queue.Count();
                    for (var i = 0; i < size; i++)
                    {
                        var curr = queue.Dequeue();
                        var nodeList = new List<Node>();
                        var newNode = new Node(curr.val, new List<Node>(curr.neighbors));
                        if (isFirstNode)
                        {
                            result = newNode;
                            isFirstNode = false;

                        } 

                        foreach (var n in curr.neighbors)
                        {
                        nodeList.Add(n);
                            if (hashset.Contains(n.val)) continue;
                            queue.Enqueue(n);
                            hashset.Add(n.val);
                        }

                    }
                }
                return result;
            }

        }
    

}