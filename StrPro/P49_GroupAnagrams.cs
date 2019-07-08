
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.StrPro
{
    class P49_GroupAnagrams
    {

        //note:

        // 1. GetHashCode
        // 2. Dictionary.Values.ToArray
        // 3. str.OrderBy(c => c)   


        public IList<IList<string>> GroupAnagrams(string[] strs)
        {

            var dict = new Dictionary<int, List<string>>();
            if (strs.Count() == 0) return dict.Values.ToArray();

            foreach (var str in strs)
            { 
                var key =  str.OrderBy(c => c).ToString().GetHashCode();
                if (dict.ContainsKey(key))
                {
                    dict[key].Add(str);
                }
                else
                {
                    dict.Add(key, new List<string>());
                    dict[key].Add(str);
                }
            }
            return dict.Values.ToArray();
        }
    }
}
