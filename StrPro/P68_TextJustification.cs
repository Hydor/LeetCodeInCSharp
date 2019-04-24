
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.StrPro
{
    class P68_TextJustification
    {
         // 97.83%      26.32%
        public static IList<string> FullJustify(string[] words, int maxWidth)
        {
            var list = new List<string>();
            var letterCounter = 0;
            var wordCounter = 0;
            for (var i = 0; i < words.Count(); i++)
            {
                letterCounter += words[i].Length;
                wordCounter++;


                
                if (letterCounter + wordCounter - 1 > maxWidth  )
                {
                    letterCounter -= words[i].Length;
                    wordCounter--;
                    if (wordCounter == 1)
                    { list.Add(words [i-1]+ InterSpace(maxWidth - words[i-1].Length)); }
                    else
                    {
                        var spaceNum = (maxWidth - letterCounter) / (wordCounter - 1);
                        var extra = (maxWidth - letterCounter) % (wordCounter - 1);
                        var sb = new StringBuilder();
                        for (var j = 0; j < wordCounter-1; j++)
                        {
                            sb.Append(words[i - wordCounter + j]);
                            sb.Append(InterSpace((j < extra && extra != 0) ? spaceNum + 1 : spaceNum));
                        }
                        sb.Append(words[i - 1]);
                        list.Add(sb.ToString());
                    }
                    i--;
                    letterCounter = 0;
                    wordCounter = 0;

                }
                else if(i == words.Count() - 1)
                {
                    var sb = new StringBuilder();
                    for (var j = 0; j < wordCounter; j++)
                    {
                        sb.Append(words[i - wordCounter + j + 1]);
                        sb.Append(" ");
                    }
                    var str = sb.ToString().Trim();
                    list.Add(str + InterSpace(maxWidth - letterCounter - wordCounter + 1));

                }

            }
            return list;
        }
        private static string InterSpace(int n)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(" ");
            }
            return sb.ToString();
        }
    }
}
