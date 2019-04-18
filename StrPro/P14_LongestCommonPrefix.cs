
using System.Linq;

namespace LeetCode.StrPro
{
    class P14_LongestCommonPrefix
    {


        //96%   52%
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Count() == 0) return "";
            var l = int.MaxValue;
            foreach (var s in strs)
            {
                if (s.Length < l) l = s.Length;
            }
            var lcp = strs[0].Substring(0, l);

            for (var i = 0; i < l; i++)
            {
                foreach (var s in strs)
                {
                    if (lcp[i] != s[i]) return lcp.Substring(0, i);
                }
            }
            return lcp;
        }
    }
}
