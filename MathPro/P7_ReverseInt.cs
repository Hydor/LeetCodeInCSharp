

namespace LeetCode.MathPro
{
    class P7_ReverseInt
    {
        //100%   98%
        public static int Reverse(int x)
        {
                long result = 0l;
                while (x != 0)
                {
                    result = result * 10 + x % 10;
                    x = x / 10;
                }
                int test = (int)result;
                return (test == result) ? test : 0;
            }
        
    }
}
