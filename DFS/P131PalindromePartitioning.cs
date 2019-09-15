using System.Collections.Generic;
using System.Linq;

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
            var partition = new List<string>(p);
            if (startIndex == s.Length)
            {
                result.Add(partition);
                return;
            }

            for (var i = startIndex; i < s.Length; i++)
            {
                var sub = s.Substring(startIndex, i- startIndex + 1);   // java's substring(startIndex, endIndex)      C#'s Substring(startIndex, SubLength)
                if (!IsPalindrome(sub)) continue;
                partition.Add(sub);
                Helper(s, result, partition, i + 1);
                partition.RemoveAt(partition.Count() - 1);       // Better to write as RemoveAt , but not Remove(x.Last()) cuz sometime it may remove the first element
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
