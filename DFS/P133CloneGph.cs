using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DFS
{
    class P133CloneGph
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





        public Node CloneGraph(Node node)
        {
            if (node == null) return new Node();
            var map = new Dictionary<Node, Node>();   // key = old node, value = new
            DFSHelper(node, map);
            return map[node];
        }


        private void DFSHelper(Node oldnode, Dictionary<Node, Node> map)
        {
            if (map.ContainsKey(oldnode)) return;

            var newList = new List<Node>();
            var nNode = new Node(oldnode.val, newList);
            map.Add(oldnode, nNode);
            foreach (var nb in oldnode.neighbors)
            {
                DFSHelper(nb, map);
                if (map.ContainsKey(nb)) newList.Add(map[nb]);
            }
        }
    }
}
