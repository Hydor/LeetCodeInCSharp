using System.Text;

namespace LeetCode.MathPro
{
    class P67_AddBinary
    {
        // 100.00%    83.33%
        public string AddBinary(string a, string b)
        {
            var result = new StringBuilder();
            var carry = 0;
            var aIndex = a.Length - 1;
            var bIndex = b.Length - 1;
            while (aIndex >= 0 || bIndex >= 0)
            {
                var numberA = aIndex >= 0 ? a[aIndex] - '0' : 0;
                var numberB = bIndex >= 0 ? b[bIndex] - '0' : 0;
                var oneResult = numberA + numberB + carry;
                carry = oneResult / 2;
                result.Append((char)(oneResult % 2 + '0'));
                aIndex--;
                bIndex--;
            }

            if (carry != 0)
            {
                result.Append((char)(carry + '0'));
            }

            return Reverse1(result.ToString());
        }

        public static string Reverse1(string str)
        {
            var sb = new StringBuilder(str.Length);
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }

    }
}
