
using System.Linq;
namespace LeetCode.StrPro
{
    class P344_ReverseString
    {
        //91.64%    64.67%
        public void ReverseString(char[] s)
        {
            var temp = ' ';

            for (int i = 0; i < s.Count() / 2; i++)
            {
                temp = s[i];
                s[i] = s[s.Count() - 1 - i];
                s[s.Count() - 1 - i] = temp;
            }
        }
    }
}
