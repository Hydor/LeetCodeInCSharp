using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.StrPro
{
    class P722RemoveComments
    {
        public IList<string> RemoveComments(string[] source)
        {
            var result = new List<string>();
            if (source == null || source.Count() == 0) return result;

            var multiline = false;
            var singleline = false;
            var bld = new StringBuilder();
            foreach (var s in source)
            {
                if (!multiline)
                {
                    bld = new StringBuilder();
                }
                for (int i = 0; i < s.Length; i++)
                {
                    char c = s[i];
                    if (multiline)
                    {
                        if (c == '*' && i < s.Length - 1 && s[i + 1] == '/')
                        {
                            i++;
                            multiline = false;
                        }
                    }
                    else if (singleline)
                    {
                        continue;
                    }
                    else if (c == '/' && i < s.Length - 1)
                    {
                        if (s[i + 1] == '/')
                        {
                            singleline = true;
                            i++;
                        }
                        else if (s[i + 1] == '*')
                        {
                            multiline = true;
                            i++;
                        }
                        else bld.Append(c);
                    }
                    else bld.Append(c);
                }
                singleline = false;
                if (!multiline && bld.ToString().Length > 0) result.Add(bld.ToString());
            }
            return result;

        }
    }
}
