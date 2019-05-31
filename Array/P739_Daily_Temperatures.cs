using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    class P739_Daily_Temperatures
    {
        public static int[] DailyTemperatures(int[] T)
        {
            var res = new int[T.Count()];
            var dic = new Dictionary<int, List< int >> ();
            for (var i = 0; i < T.Count(); i++)
            {
                if (dic.ContainsKey(T[i])) { dic[T[i]].Add(i); }
                else {
                    dic.Add(T[i], new List<int>());
                    dic[T[i]].Add(i);
                }
            }

            for (int i = 0; i < T.Count(); i++)
            {
                if (T[i] == 100) res[i] = 0;
                else {
                    if (T[i] > 95)
                    {
                        for (var s = 0; s < T.Count(); s++)
                        {
                            var plus = T[s] + 1;
                            while (plus <= 100)
                            {
                                if (dic.ContainsKey(plus))
                                {
                                    foreach (var item in dic[plus])
                                    { if (item > s) res[s] = item - s; }
                                }
                                plus++;
                            }
                        }
                    }
                    else
                    {
                        for (var step = 1; step < T.Count() - i; step++)
                        {
                            if (T[i + step] > T[i])
                            { res[i] = step; break; }
                            else if (i + step == T.Count() - 1) res[i] = 0;
                        }
                    }
                }
            }

            
            return res;
        }
    }
}
