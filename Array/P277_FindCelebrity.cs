using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    public class P277_FindCelebrity
    {
        public static int FindCelebrity(int n)
        {
            if (n<2) return -1;
            for (int i = 0; i < n;)
            {
                for (int j = 0; j < n; j++)
                {
                    if (!Knows(j, i)) break;
                    if (j == n - 1)
                    {
                        for (int k = 0; k < n; k++)
                        {
                            if (Knows(i,k) && i!=k) break;
                            if (k == n - 1) return i;
                        }                        
                    } 
                }
                i++;
            }
            return -1;
        }

        static  bool Knows(int i, int j)
        { 
            //example 1
            if (i == 0 && j == 0) return true;
            if (i == 1 && j == 0) return true;
            if (i == 2 && j == 0) return false;
            if (i == 0 && j == 1) return false;
            if (i == 1 && j == 1) return true;
            if (i == 2 && j == 1) return false;
            if (i == 0 && j == 2) return true;
            if (i == 1 && j == 2) return true;
            if (i == 1 && j == 2) return true;

            return true;
        }
    }

}
