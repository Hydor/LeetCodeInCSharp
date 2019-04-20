using System.Linq;
using System.Text;

namespace LeetCode.StrPro
{
    class P151_ReverseWordsString
    {
        public static string ReverseWords(string s)
        {
            while (s.Contains("  ")) { s = s.Replace("  ", " "); }
            var sArr = s.Split(' ');
            var sb = new StringBuilder();
            for (var i = sArr.Count() - 1; i >= 0; i--)
            {
                if (sArr[i].ToString()!="")
                {
                    sb.Append(sArr[i]);
                    if (i != 0 && sArr[i-1] != "" ) sb.Append(" ");
                }
            }            
            return sb.ToString();
        }
    }
}
