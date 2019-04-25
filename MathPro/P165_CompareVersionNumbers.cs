using System;
using System.Linq;
namespace LeetCode.MathPro
{
    class P165_CompareVersionNumbers
    {
        // Split -> Convert -> Compare     24.28%     5.88%
        public int CompareVersion(string version1, string version2)
        {
            var v1 = version1.Split('.');
            var v2 = version2.Split('.');
            var i = 0;
            while (true)
            {
                if (i == v1.Count() && i < v2.Count())
                {
                    return CheckRestIs0(v2, i) ? 0 : -1;
                }
                else if (i < v1.Count() && i == v2.Count())
                {
                    return CheckRestIs0(v1, i) ? 0 : 1;
                }
                else if (Convert.ToInt32(v1[i]) == Convert.ToInt32(v2[i]))
                {
                    if (i == v1.Count() - 1 && i == v2.Count() - 1)
                    { return 0; }
                    else { i++; }
                }
                else
                {
                    return Convert.ToInt32(v1[i]) > Convert.ToInt32(v2[i]) ? 1 : -1;
                }
            }
        }


        private bool CheckRestIs0(string[] s, int index)
        {
            for (var i = index; i < s.Count(); i++)
            {
                if (Convert.ToInt32(s[i]) != 0) return false;
            }
            return true;
        }


        // Compare by number    47.11%    5.88%
        public static int CompareVersion2(string version1, string version2)
        {
            var i = 0;
            var j = 0;
            var num1 = 0;
            var num2 = 0;
            while (i < version1.Length || j < version2.Length)
            {
                while (i < version1.Length && version1[i] != '.') { num1 = num1 * 10 + Convert.ToInt32(version1[i++].ToString()); }
                while (j < version2.Length && version2[j] != '.') { num2 = num2 * 10 + Convert.ToInt32(version2[j++].ToString()); }
                if (num1 == num2) { i++; j++; num1 = 0; num2 = 0; }
                else return num1 > num2 ? 1 : -1;
            }
            return 0;
        }


    }
}
