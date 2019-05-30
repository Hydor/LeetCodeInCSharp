using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.MathPro
{
    class P1053
    {

  
            public static  int[] PrevPermOpt1(int[] A)
            {
                var best = A;
                var far = 0;
                if (A.Count() <= 1) return A;
                var temp = 0;
                for (var i = A.Count() - 1; i >= far ; i--)
                {
                    for (var j = i - 1; j >= far ; j--)
                    {
                        if (A[i] < A[j])
                        {
                            var b = new int[A.Count()];
                            System.Array.Copy(A, b, A.Length);
                            temp = b[i];
                            b[i] = b[j];
                            b[j] = temp;
                            far = j +1;
                            best = b;
                            break;
                        }
                    }
                }
                return best;
            }

        
    }
}
