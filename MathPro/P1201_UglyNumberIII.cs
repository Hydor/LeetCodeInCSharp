using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.MathPro
{
    class P1201_UglyNumberIII
    {
        public int NthUglyNumber(int n, int a, int b, int c)
        {
            int low = 1, high = int.MaxValue, mid;

            while (low < high)
            {
                mid = low + (high - low) / 2;

                // If the current term is less than  
                // n then we need to increase low  
                // to mid + 1  
                if (divTermCount(a, b, c, mid) < n)
                    low = mid + 1;

                // If current term is greater than equal to  
                // n then high = mid  
                else
                    high = mid;
            }

            return low;
        }

        public long gcd(long a, long b)
        {
            if (a == 0)
                return b;

            return gcd(b % a, a);
        }

        // Function to return the lcm of a and b  
        public long lcm(long a, long b)
        {
            return (a * b) / gcd(a, b);
        }

        // Function to return the count of numbers  
        // from 1 to num which are divisible by a, b or c  
        public long divTermCount(long a, long b, long c, long num)
        {

            // Calculate number of terms divisible by a and  
            // by b and by c then, remove the terms which is are  
            // divisible by both a and b, both b and c, both  
            // c and a and then add which are divisible by a and  
            // b and c  
            return ((num / a) + (num / b) + (num / c)
                    - (num / lcm(a, b))
                    - (num / lcm(b, c))
                    - (num / lcm(a, c))
                    + (num / lcm(a, lcm(b, c))));
        }

    }
}
