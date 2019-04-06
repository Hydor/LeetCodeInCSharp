using System;
using System.Linq;
using System.Collections.Generic;

namespace LeetCode.Array
{
    public class WordDistance
    {

        // DictionaryMap   38.00%    100%
        public Dictionary<string ,List<int>> map;       

        public WordDistance(string[] words)
        {
            map = new Dictionary<string, List<int>>();            
            for (int i = 0; i < words.Length; i++){
                if (!map.ContainsKey(words[i])){
                    map.Add(words[i], new List<int>());
                }
                map[words[i]].Add(i);
            }
        }

        public int Shortest(string word1, string word2)
        {           
            if (map.Count == 0) return 0;
            
            var dis = new int [map[word1].Count* map[word2].Count];
            var z = 0;
            for (int i = 0; i < map[word1].Count; i++)
            {
                for (int j = 0; j < map[word2].Count; j++)
                {
                    dis[z] = Math.Abs(map[word1][i] - map[word2][j]);
                    z++;
                }
            }             
            return dis.Min();
        }

    }
}
