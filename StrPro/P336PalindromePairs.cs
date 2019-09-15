using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.StrPro
{
    class P336PalindromePairs
    {
        public IList<IList<int>> PalindromePairs(string[] words)
        {
            var result = new List<IList<int>>();
            if (words == null || words.Length == 0)
            {
                return result;
            }

            // Add all string[] to dictionary 
            var dict = new Dictionary<string, int>();
            for (var i = 0; i < words.Length; i++)
            {
                dict.Add(words[i], i);
            }


            for (var i = 0; i < words.Length; i++)
            {
                var sub = "";
                if (dict.ContainsKey(sub) && i != dict[sub] && IsPalindrome(words[i]))
                {
                    var pair = new List<int>();
                    var pair2 = new List<int>();
                    pair.Add(i);
                    pair.Add(dict[sub]);
                    pair2.Add(dict[sub]);
                    pair2.Add(i);
                    result.Add(pair);
                    result.Add(pair2);
                }
                for (var j = 0; j < words[i].Length; j++)
                {
                    sub = words[i][j] + sub;

                    if (dict.ContainsKey(sub))
                    {
                        if (IsPalindrome(words[i] + sub) && i != dict[sub])
                        {
                            var pair = new List<int>();
                            pair.Add(i);
                            pair.Add(dict[sub]);
                            result.Add(pair);
                        }
                    }
                }
                sub = "";
                for (var j = words[i].Length - 1; j > 0; j--)
                {
                    sub += words[i][j];

                    if (dict.ContainsKey(sub))
                    {
                        if (IsPalindrome(sub + words[i]) && i != dict[sub])
                        {
                            var pair = new List<int>();
                            pair.Add(dict[sub]);
                            pair.Add(i);
                            result.Add(pair);
                        }
                    }
                }
            }

            return result;
        }


        private bool IsPalindrome(string str)
        {
            for (int i = 0, j = str.Length - 1; i < j;)
            {
                if (str[i++] != str[j--]) return false;
            }
            return true;
        }

    }
}
