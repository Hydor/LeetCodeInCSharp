using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.StrPro
{
    class P28_ImplementStr
    {
        // IndexOf    24.69%         20.29%
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0) return 0;
            if (!haystack.Contains(needle)) return -1;
            return haystack.IndexOf(needle);
        }

        
        //  53.38%    64%
        public static int StrStr2(string haystack, string needle)
        {
            if (needle.Length == 0) return 0;
            if (!haystack.Contains(needle)) return -1;
            if (haystack.Length == needle.Length) return haystack == needle ? 0 : -1;
            var probIndex = -1;
            var h = haystack.ToCharArray();
            var n = needle.ToCharArray();
            var flag = true;
            for (var i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (h[i] == n[0])
                {
                    flag = true;
                    probIndex = i;
                    if (n.Count() == 1) return probIndex;
                    for (var j = 1; j < n.Count(); j++)
                    {
                        if (h[i + j] != n[j]) { probIndex = -1;  flag = false;break; }
                    }
                    if (flag) return probIndex;
                }
            }
            return probIndex;
        }
        
        // 99%    50%
        public static int StrStr3(string haystack, string needle)
        {
                if (needle.Length == 0) return 0;
                if (!haystack.Contains(needle)) return -1;
                if (haystack.Length == needle.Length) return haystack == needle ? 0 : -1;
                for (var i = 0; i <= haystack.Length - needle.Length; i++)
                {
                    if (haystack[i] == needle[0])
                    {
                        if (needle.Length==1)return i;
                        for (var j = 1; j < needle.Length; j++)
                        {
                            if (haystack[i + j] != needle[j]) { break; }
                            if (j == needle.Length - 1) return i;
                        }
                    
                    }
                }
                return -1;
        }
        
    }
}
