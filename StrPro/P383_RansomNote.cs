using System.Collections.Generic;

namespace LeetCode.StrPro
{
    class P383_RansomNote
    {
        // two Dictionary  47.93%   29.63%
        public bool CanConstruct(string ransomNote, string magazine)
        {

            var dicR = new Dictionary<char, int>();
            var dicM = new Dictionary<char, int>();
            foreach (var i in ransomNote)
            {                
                if (dicR.ContainsKey(i)) dicR[i] += 1;
                else dicR.Add(i, 1);
            }
            foreach (var i in magazine)
            {
                if (dicM.ContainsKey(i)) dicM[i] += 1;
                else dicM.Add(i, 1);
            }
            foreach (var i in dicR)
            {
                if (!dicM.ContainsKey(i.Key) || dicM[i.Key] < i.Value) return false;
            }
            return true;

        }



        // one Dictionary    47.93%    44.44%
        public bool CanConstruct2(string ransomNote, string magazine)
        {
            var dicM = new Dictionary<char, int>();
            foreach (var i in magazine)
            {
                if (dicM.ContainsKey(i)) dicM[i] += 1;
                else dicM.Add(i, 1);
            }
            foreach (var i in ransomNote)
            {
                if (!dicM.ContainsKey(i) || dicM[i] == 0) return false;
                else dicM[i] --;
            }
            return true;
        }
    }
}
