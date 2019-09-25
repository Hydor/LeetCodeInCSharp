using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BFS
{
    class P127_WordLadder
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            if (wordList == null)
                return 0;
            var steps = 1;

            // use hashset to dedup
            var set = new HashSet<string>();

            set.Add(beginWord);
            // put wordList into a mapping Dictionary, treat it as a graph
            var dict = new Dictionary<string, IList<string>>();
            if (!wordList.Contains(beginWord)) wordList.Add(beginWord);
            MapToDictionary(dict, wordList);

            // Use BFS to search the shortest Path
            var queue = new Queue<string>();
            queue.Enqueue(beginWord);

            while (queue.Any())
            {

                var size = queue.Count();
                steps++;
                for (var i = 0; i < size; i++)
                {
                    var curr = queue.Dequeue();
                    foreach (var item in dict[curr])
                    {
                        if (item == endWord) return steps;

                        if (set.Contains(item)) continue;
                        set.Add(item);
                        queue.Enqueue(item);

                    }
                }


            }
            return 0;

        }

        //
        private void MapToDictionary(Dictionary<string, IList<string>> dict, IList<string> wordList)
        {
            var wordset = new HashSet<string>();
            foreach (var item in wordList)
            { wordset.Add(item); }
            foreach (var item in wordList)
            {
                dict.Add(item, GetNeighbors(item, wordset));
            }
        }

        // time limit exceeded
        private bool IsNeighbor(string s1, string s2)
        {
            if (s1 == s2 || s1.Length != s2.Length) return false;
            var diffLetter = 0;
            for (var i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    diffLetter++;
                    if (diffLetter > 1) return false;
                }
            }
            return true;
        }

        private List<string> GetNeighbors(string s1, HashSet<string> wordset)
        {
            var neighbors = new List<string>();
            for (var i = 0; i < s1.Length; i++)
            {
                var chars = s1.ToCharArray();
                for (var c = 'a'; c <= 'z'; c++)
                {
                    if (s1[i] == c) continue;
                    chars[i] = c;
                    var newstr = new string(chars);
                    if (wordset.Contains(newstr))
                    {
                        neighbors.Add(newstr);
                    }
                }
            }
            return neighbors;
        }
    }
}
