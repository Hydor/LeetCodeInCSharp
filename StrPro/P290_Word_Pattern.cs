using System.Collections.Generic;
using System.Linq;


namespace LeetCode.StrPro
{
    class P290_Word_Pattern
    {
        public bool WordPattern(string pattern, string str)
        {

            var t = str.Split(' ');
            if (pattern.Length != t.Count()) return false;
            var dict = new Dictionary<char, string>();

            var dictT = new Dictionary<string, char>();
            for (var i = 0; i < pattern.Length; i++)
            {
                if (dict.ContainsKey(pattern[i]))
                {
                    if (dict[pattern[i]] != t[i]) return false;
                }
                else { dict.Add(pattern[i], t[i]); }
                if (dictT.ContainsKey(t[i]))
                {
                    if (dictT[t[i]] != pattern[i]) return false;
                }
                else { dictT.Add(t[i], pattern[i]); }
            }
            return true;
        }
    }
}
