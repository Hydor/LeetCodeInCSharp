
using System.Linq;

namespace LeetCode.StrPro
{
    class P186ReverseWords
    {
        public static void ReverseWords(char[] str)
        {
            System.Array.Reverse(str);
            var beginIndex = 0;
            var endIndex = 0;
            var temp = ' ';
            for (int i = 0; i < str.Count(); i++)
            {
                if (str[i] == ' ')
                {
                    endIndex = i - 1;
                    for (int j = 0; j <= (endIndex - beginIndex) / 2; j++)
                    {
                        temp = str[j + beginIndex];
                        str[j + beginIndex] = str[endIndex - j];
                        str[endIndex - j] = temp;
                    }
                    beginIndex = i + 1;
                }
                else if (i == str.Count() - 1)
                {
                    endIndex = i;
                    for (int j = 0; j <= (endIndex - beginIndex) / 2; j++)
                    {
                        temp = str[j + beginIndex];
                        str[j + beginIndex] = str[endIndex - j];
                        str[endIndex - j] = temp;
                    }
                    beginIndex = i + 1;
                }
            }
        }
    }
}
