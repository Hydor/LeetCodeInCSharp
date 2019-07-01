using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.StrPro
{
    class P819_MostCommonWord
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            if (paragraph.Length == 0)
            {
                return "";
            }
            var dict = new Dictionary<string, int>();
            var currWord = "";
            var lowchar = new char();
            for (var i = 0; i < paragraph.Count(); i++)
            {
                lowchar = char.ToLower(paragraph[i]);
                if (!IsLetter(lowchar) && currWord != "")
                {
                    if (dict.ContainsKey(currWord))
                    {
                        dict[currWord] += 1;
                    }
                    else
                    {
                        dict.Add(currWord, 1);
                    }
                    currWord = "";
                }
                if (IsLetter(lowchar))
                {
                    currWord += char.ToLower(lowchar);

                }
                if (i == paragraph.Count() - 1 && currWord != "")
                {
                    if (dict.ContainsKey(currWord))
                    {
                        dict[currWord] += 1;
                    }
                    else
                    {
                        dict.Add(currWord, 1);
                    }
                }
            }

            var max = 0;
            var res = "";
            foreach (var d in dict)
            {
                if (!banned.Contains(d.Key) && d.Value > max)
                {
                    res = d.Key;
                    max = d.Value;
                }
            }
            return res;
        }




        bool IsLetter(char c)
        {
            return (c >= 'a' && c <= 'z');
        }
    }
}
