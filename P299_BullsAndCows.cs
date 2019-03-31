using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    class P299_BullsAndCows
    {


        //   Brute Force  5.47%   14,3%…
        public static string GetHint(string secret, string guess)
        {
            var s = secret.ToCharArray();
            var g = guess.ToCharArray();
            var A = 0;
            var B = 0;
            var checkedArrS = new int[s.Count()];

            var checkedArrG = new int[s.Count()];
            for (int i = 0; i < s.Count(); i++)
            {
                if (  s[i] == g[i])
                {
                    A++;
                    checkedArrS[i] = 1; checkedArrG[i] = 1;
                    break;
                }
            }
            for (int i = 0; i < s.Count(); i++)
            {
                for (int j = 0; j < g.Count(); j++)
                {
                     if (checkedArrS[i]!=1 && checkedArrG[j]!=1 && secret[i]==guess[j]) 
                    {B++; checkedArrG[j] = 1;  break;}
            
                } 
            }
            return A+"A"+B + "B";
        }
    }
}
