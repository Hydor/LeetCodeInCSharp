using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.MathPro
{
    class P69_Divide2Integers
    {
        private int DivideRec(int dividend, int divisor, int pow)
        {
            if (pow < 0)
                return 0;
            int count = 0;
            while (dividend <= divisor << pow)
            {
                dividend -= divisor << pow;
                count += 1 << pow;
            }
            count += DivideRec(dividend, divisor, pow - 1);
            return count;
        }

        public int Divide(int dividend, int divisor)
        {
            // Strategy: subtract abs dividend by abs divisor n times until dividend is no longer positive
            // Optimization: use bit-shifting to effectively subtract n * x times while we can do so
            // Since you cannot take absolute value of int.MinValue without overflowing,
            // we'll work around this by using the negative absolute values in place of the parameters

            // Handle edge case
            if (dividend == Int32.MinValue && divisor == -1) //solution will overflow
                return Int32.MaxValue;

            //Since int MinValue has a bigger absolute value range than int MaxValue, always work in negative numbers for this algorithm
            int absNegDividend = (dividend <= 0 ? dividend : dividend - dividend - dividend);
            int absDivisor = (divisor == int.MinValue ? int.MaxValue : divisor >= 0 ? divisor : divisor - divisor - divisor);
            int absNegDivisor = (divisor <= 0 ? divisor : divisor - divisor - divisor);

            //Determine how many times we can bit-shift our divisor without overflow
            int pow = 0;
            for (int i = 0; i < 30; i++)
            {
                if (absDivisor << i > (1 << 30 - 1))
                    break;
                pow++;
            }

            int result = DivideRec(absNegDividend, absNegDivisor, pow);

            // https://www.youtube.com/watch?v=Q3a-bXXN9Xc
            if (absNegDivisor != divisor ^ absNegDividend != dividend)
                result = result - result - result;

            return result;
        }
    }
}
