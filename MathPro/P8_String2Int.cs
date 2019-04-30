using System;
using System.Linq;
using System.Text;

namespace LeetCode.MathPro
{
    class P8_String2Int
    {

        //16.74%   16.50% 
        public static int MyAtoi(string str)
        {
            str = str.Trim();
            if (str.Length == 0) return 0;
            var i = 0;
            var sb = new StringBuilder();
            var minus = false;
            var legalLetter = "0123456789";
            if (str[0] == '-') { minus = true; i++; }
            else if (str[0] == '+') { i++; }
            else if (!legalLetter.Contains(str[0])) return 0;

            while (i < str.Length)
            {
                if (legalLetter.Contains(str[i]))
                {
                    sb.Append(str[i++]);
                }
                else { break; }

            }
            if (sb.ToString() == "") return 0;
            var trans = int.TryParse(sb.ToString(), out var num);
            if (!trans)
            {
                return (minus) ? int.MinValue : int.MaxValue;
            }

            return (minus) ? -num : num;
        }


        //  83.40%     19.53% 
        public static int MyAtoi2(string str)
        {
            str = str.Trim();
            if (str.Length == 0) return 0;
            var i = 0;
            var num = 0;
            var minus = false;
            var legalLetter = "0123456789";
            if (str[0] == '-') { minus = true; i++; }
            else if (str[0] == '+') { i++; }

            while (i < str.Length)
            {
                if (legalLetter.Contains(str[i]))
                {
                    var next = num * 10 + Convert.ToInt32(str[i++].ToString());
                    if (((num * 10) / 10) != num || next < num) return (minus) ? int.MinValue : int.MaxValue;
                    num = (next < 0) ? -next : next;
                }
                else { break; }

            }         

            return (minus) ? -num : num;
        }

    }
}
