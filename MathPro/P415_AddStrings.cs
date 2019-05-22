using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.MathPro
{
    class P415_AddStrings
    {
        public static string AddStrings(string num1, string num2)
        {
            var carry = 0;
            var i = 1;
            var n1 = 0;
            var n2 = 0;
            var sb = new StringBuilder();
            var n = 0;
            while (true)
            {

                if (i > num1.Length) { n1 = 0; }
                else { n1 = GetNum(num1[num1.Length - i]); }
                if (i > num2.Length) { n2 = 0; }
                else { n2 = GetNum(num2[num2.Length - i]); }

                n = n1 + n2 + carry;
                if (n >= 10)
                {
                    n = n % 10;
                    carry = 1;
                }
                else
                { carry = 0; }
                sb.Append(n.ToString());

                i++;
                if (i > num1.Length && i > num2.Length)
                {
                    if (carry == 1) sb.Append("1");
                    break;
                }

            }

            return new string(sb.ToString().ToCharArray().Reverse<char>().ToArray<char>());

        }


        static public int GetNum(char c)
        {
            switch (c)
            {
                case '0': return 0; break;
                case '1': return 1; break;
                case '2': return 2; break;
                case '3': return 3; break;
                case '4': return 4; break;
                case '5': return 5; break;
                case '6': return 6; break;
                case '7': return 7; break;
                case '8': return 8; break;
                case '9': return 9; break;
            }
            return 0;
        }
    }
}
