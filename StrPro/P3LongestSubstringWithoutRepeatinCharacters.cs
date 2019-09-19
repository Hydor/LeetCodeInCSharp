using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.StrPro
{
    class P3LongestSubstringWithoutRepeatinCharacters
    {
        public static int LengthOfLongestSubstring(string s)
        {
            var maxLength = 0;
            if (s == null || s.Length == 0) return maxLength;

            var queue = new Queue<int>();       //use <int> instead of <char>, will be faster
            var index = 1;
            queue.Enqueue(s[0]);     
            while (queue.Any() && index < s.Length)  
            {
                if (queue.Contains(s[index]))
                {
                    maxLength = Math.Max(queue.Count(), maxLength);     // Every time found duplicate elements, record max length
                    while (s[index] != queue.Dequeue()) ;               // Extract elements until move out the duplicate element
                }
                
                queue.Enqueue(s[index]);
                if (index++ == s.Length - 1) break;
            }

            return Math.Max(queue.Count(), maxLength);
        }
    }
}
