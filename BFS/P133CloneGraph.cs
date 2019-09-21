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
            var map = new Dictionary<Node, Node>();  // mapping relationship key = old node, v = new  
            map.Add(node, new Node());
            var queue = new Queue<Node>();
            queue.Enqueue(node);

            // copy all nodes
            while (queue.Any())
            {
                var curr = queue.Dequeue();
                foreach (var nb in curr.neighbors)
                {
                    if (map.ContainsKey(nb)) continue;
                    map.Add(nb, new Node());
                    queue.Enqueue(nb);
                }
            }

            // add their neighbors relationship to these new nodes        
            foreach (var item in map)
            {
                item.Value.val = item.Key.val;

                List<Node> neighbors = new List<Node>();
                foreach (var neighbor in item.Key.neighbors)
                {
                    neighbors.Add(map[neighbor]);
                }

                item.Value.neighbors = neighbors;
            }


            return map[node];
        }

    }

}
