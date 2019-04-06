using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Array
{
    class P255_ShortestWordsDis
    {

        // Dictionary Map  39%   100%
        public int ShortestWordDistance2(string[] words, string word1, string word2)
        {
            var map = new Dictionary<string, List<int>>();
            var shortest = 900000;
            for (int i = 0; i < words.Length; i++)
            {
                if (!map.ContainsKey(words[i]))
                {
                    map.Add(words[i], new List<int>());
                }
                map[words[i]].Add(i);
            }
            if (word1 == word2 && map[word1].Count < 2)
            {
                return 0;
            }
            else if (word1 == word2 && map[word1].Count >= 2)
            {

                for (int i = 0; i < map[word1].Count - 1; i++)
                {
                    shortest = Math.Min(shortest, map[word1][i + 1] - map[word1][i]);
                }
                return shortest;
            }
            else
            {
                var dis = new int[map[word1].Count * map[word2].Count];
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


        // two point    100%  100%
        public int ShortestWordDistance(string[] words, string word1, string word2)
        {
            var countArr = 50000;
            var point1 = -1;
            var point2 = -1;
            var flag = true;
            for (int i = 0; i < words.Count(); i++)
            {
                if (word1 == word2)
                {
                    if (words[i] == word1 || words[i] == word2)
                    {
                        if (flag)
                        {
                            point1 = i;
                            flag = false;
                            if (point1 != -1 && point2 != -1) { countArr = Math.Min(countArr, point1 - point2); }
                        }
                        else
                        {
                            flag = true;
                            point2 = i;
                            if (point1 != -1 && point2 != -1) { countArr = Math.Min(countArr, point2 - point1); }
                        }
                    }
                }
                else
                {
                    if (words[i] == word1)
                    {
                        point1 = i;

                        if (point1 != -1 && point2 != -1) { countArr = Math.Min(countArr, point1 - point2); }
                    }
                    else if (words[i] == word2)
                    {

                        point2 = i;
                        if (point1 != -1 && point2 != -1) { countArr = Math.Min(countArr, point2 - point1); }
                    }
                }
            }

            return countArr;
        }
    }
}
