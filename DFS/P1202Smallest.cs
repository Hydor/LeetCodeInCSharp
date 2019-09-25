using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DFS
{
    class P1202Smallest
    {
        public string SmallestStringWithSwaps(string s, IList<IList<int>> pairs)
        {
            if (pairs == null || s.Length <= 1 || pairs.Count() == 0) return s;
            var dict = new Dictionary<int, List<int>>();
            foreach (var p in pairs)
            {
                if (!dict.ContainsKey(p[0])) dict.Add(p[0], new List<int>());
                if (!dict.ContainsKey(p[1])) dict.Add(p[1], new List<int>());
                if (!dict[p[0]].Contains(p[1])) dict[p[0]].Add(p[1]);
                if (!dict[p[1]].Contains(p[0])) dict[p[1]].Add(p[0]);
            }

            var visited = new bool[s.Length];
            var chararr = s.ToCharArray();
            for (var i = 0; i < s.Length; i++)
            {
                if (!visited[i] && dict.ContainsKey(i))
                {
                    var indexes = new List<int>();
                    var contents = new List<char>();
                    DFSHelper(dict, chararr, visited, indexes, contents, i);
                    indexes.Sort();
                    contents.Sort();
                    for (int j = 0; j < indexes.Count(); j++)
                    {
                        chararr[indexes[j]] = contents[j];
                    }
                }
            }

            return new string(chararr);
        }

        private void DFSHelper(Dictionary<int, List<int>> dict,
                               char[] chararr,
                               bool[] visited,
                               List<int> indexes,
                               List<char> contents,
                               int startIndex
                              )
        {
            visited[startIndex] = true;
            indexes.Add(startIndex);
            contents.Add(chararr[startIndex]);
            foreach (var child in dict[startIndex])
            {
                if (!visited[child])
                {
                    DFSHelper(dict, chararr, visited, indexes, contents, child);
                }
            }
        }

    }
}
