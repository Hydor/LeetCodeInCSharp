
using System.Linq;

namespace LeetCode.MathPro
{
    class P66_PlusOne
    {
        //      99.93%          73.97%
        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Count() - 1; i >= 0; i--)
            {
                if (digits[i] != 9)
                {
                    digits[i] += 1;
                    return digits;
                }
                else
                {
                    digits[i] = 0;
                    if (i == 0)
                    {
                        var newdigits = new int[digits.Count() + 1];
                        newdigits[0] = 1;
                        return newdigits;
                    }
                }
            }

            return digits;
        }
    }
}
