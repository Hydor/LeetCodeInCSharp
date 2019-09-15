using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DFS
{
    class P131PalindromePartitioning
    {
        public static IList<IList<string>> Partition(string s)
        {
            var result = new List<IList<string>>();
            if (s == null || s.Length == 0) return result;

            Helper(s, result, new List<string>(), 0);
            return result;
        }

        private static void Helper(string s, List<IList<string>> result, List<string> p, int startIndex)
        {
            if (startIndex == s.Length)
            {
                result.Add(new List<string>(p));
                return;
            }
            var partition = new List<string>(p);

            for (var i = startIndex; i < s.Length; i++)
            {
                var sub = s.Substring(startIndex, i- startIndex + 1);
                if (!IsPalindrome(sub)) continue;
                partition.Add(sub);
                Helper(s, result, partition, i + 1);
                partition.RemoveAt(partition.Count() - 1);       // Better to write as RemoveAt , but not Remove(x.Last())
            }

        }


        private static  bool IsPalindrome(string str)
        {
            for (int i = 0, j = str.Length - 1; i < j;)
            {
                if (str[i++] != str[j--]) return false;
            }
            return true;
        }
    }
}
