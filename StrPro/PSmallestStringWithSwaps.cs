using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.StrPro
{
    class PSmallestStringWithSwaps
    {
        public static string SmallestStringWithSwaps(string s, IList<IList<int>> pairs)
        {
            if (pairs == null || s.Length <= 1) return s;

            var hashset = new HashSet<string>();
            DFSHelper(s, pairs, hashset);
            return hashset.Min();
        }

        private static void DFSHelper(string s, IList<IList<int>> pairs, HashSet<string> hashset)
        {
            if (hashset.Contains(s)) return;
            hashset.Add(s);
            foreach (var pair in pairs)
            {
                s = Swap(s, pair[0], pair[1]);
                DFSHelper(s, pairs, hashset);
            }
        }

        private static string Swap(string s, int i, int j)
        {
            var chararr = s.ToCharArray();
            char tempchar;
            if (s[i] > s[j])
            {
                tempchar = chararr[i];
                chararr[i] = chararr[j];
                chararr[j] = tempchar;
            } 

            return new string(chararr);
        }

    }
}
