using System;
using System.Linq;

namespace LeetCode.StrPro
{
    class P443_StringCompression
    {
        public int Compress(char[] chars)
        {
            int len = 0;
            for (int i = 0, j = 0; i < chars.Count(); i = j)
            {
                while (j < chars.Count() && chars[i] == chars[j]) j++;
                chars[len++] = chars[i];
                if ((j - i) <= 1) continue;
                foreach (char count in (j - i).ToString())
                {
                    chars[len++] = count;
                }
            }
            return len;
        }
    }
}
