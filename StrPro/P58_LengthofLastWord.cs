using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.StrPro
{
    class P58_LengthofLastWord
    {

        // Split  66.03%  10.64%
        public int LengthOfLastWord(string s)
        {
            if (!s.Contains(" ")) return s.Length;
            s = s.TrimEnd(' ');
            var sArr = s.Split(' ');
            return sArr[sArr.Count() - 1].Length;
        }

        //Count Char From End      99.84%      87.23%
        public int LengthOfLastWord2(string s)
        {
            var count = 0;
            for (var i = s.Length - 1; i >= 0; i--)
            {
                if (count == 0 && s[i] == ' ') continue; 
                else if (s[i] == ' ') break;
                else { count++; }
            }
            return count;
        }

    }
}
