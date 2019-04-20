using System.Collections.Generic;

namespace LeetCode.StrPro
{
    class P387_FirstUniqueChar
    {
        // Dictionary     64.99%      30.30%
        public int FirstUniqChar(string s)
        {
            var dic = new Dictionary<char, int>();
            for (var i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i])) dic[s[i]] = -1;
                else dic.Add(s[i], i);
            }
            foreach (var i in dic)
            {
                if (i.Value >= 0) return i.Value;
            }
            return -1;
        }

     


    }
}
