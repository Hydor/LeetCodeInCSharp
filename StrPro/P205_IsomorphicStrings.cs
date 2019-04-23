using System;
using System.Collections.Generic;

namespace LeetCode.StrPro
{
    class P205_IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) return false;
            var dict = new Dictionary<char, char>();

            var dictT = new Dictionary<char, char>();
            for (var i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    if (dict[s[i]] != t[i]) return false;
                }
                else { dict.Add(s[i], t[i]); }
                if (dictT.ContainsKey(t[i]))
                {
                    if (dictT[t[i]] != s[i]) return false;
                }
                else { dictT.Add(t[i], s[i]); }
            }
            return true;
        }
    }
}
