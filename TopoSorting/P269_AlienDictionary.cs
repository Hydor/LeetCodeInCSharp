using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TopoSorting
{
    class P269_AlienDictionary
    {
        public string AlienOrder(string[] words)
        {
            var resultStr = "";
            if (words.Count() == 0)
            {
                return resultStr;
            }
            //1.put this string[] into map,  Dictionary<char, List<char>>
            //2. record all letter indegree
            var map = new Dictionary<char, List<char>>();
            var indegree = new int[26];
            for (var i = 0; i < 26; i++)
            {
                indegree[i] = -2;
            }
            for (var i = 0; i < words.Count(); i++)
            {
                var w1 = words[i];
                var w2 = (i == words.Count() - 1) ? w1 : words[i + 1];

                var com = Math.Min(w1.Length, w2.Length);
                var index = 0;
                for (; index < com; index++)
                {
                    AddtoMapnIndegree(map, indegree, w1[index], w2[index]);
                    if (w1[index] != w2[index]) break;
                }
                for (var j = index; j < w1.Length; j++)
                {
                    AddtoMapnIndegree(map, indegree, w1[j], w1[j]);
                }
                for (var j = index; j < w2.Length; j++)
                {
                    AddtoMapnIndegree(map, indegree, w2[j], w2[j]);
                }

            }

            //3.store all "first" order letter into queue (indegree = 0)
            var queue = new Queue<char>();
            for (var i = 0; i < 26; i++)
            {
                if (indegree[i] == -1 || indegree[i] == 0)
                {
                    queue.Enqueue(Convert.ToChar(i + 97));
                    if (indegree[i] == 0) break;
                }
            }


            //4. BFS
            //      take out a letter , all its next letter in list indegree -1
            //      add the indegree = 0 into queue
            //      redo until queue is empty
            while (queue.Any())
            {
                var letter = queue.Dequeue();
                resultStr += letter.ToString();
                if (map.ContainsKey(letter))
                {
                    foreach (var next in map[letter])
                    {
                        indegree[next - 'a']--;
                        if (indegree[next - 'a'] == 0)
                        {
                            queue.Enqueue(next);
                        }

                    }
                }
            }

            //5. if !outstring = allletternum  return "" 
            var countNum = indegree.Count(c => c >= -1);
            if (resultStr.Length == countNum)
            {
                return resultStr;
            }
            else
            {
                return "";
            }




        }

        void AddtoMapnIndegree(Dictionary<char, List<char>> map, int[] indegree, char first, char secound)
        {
            if (indegree[first - 'a'] == -2)
            {
                indegree[first - 'a'] = -1;
            }

            if (first == secound) return;
            if (indegree[secound - 'a'] < 0)
            {
                indegree[secound - 'a'] = 0;
            }

            if (!map.ContainsKey(first))
            {
                var l = new List<char>();
                l.Add(secound);
                map.Add(first, l);
                indegree[secound - 'a']++;
            }
            else
            {
                if (!map[first].Contains(secound))
                {
                    map[first].Add(secound);
                    indegree[secound - 'a']++;
                }
            }
        }



    }
