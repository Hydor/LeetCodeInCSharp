using System.Linq;

namespace LeetCode.MathPro
{
    class P258_Add_Digits
    {

        //Array    100%    7.69%
        public int AddDigits(int num)
        {
            var dig = new int[10];
            int i = 0;
            while (true)
            {
                dig[i++] = num % 10;
                num = num / 10;
                if (num == 0)
                {
                    i = 0;
                    num = dig.Sum();
                    System.Array.Clear(dig, 0, dig.Count());
                    if (num < 10) break;
                }
            }
            return num;
        }

        // Sum     100%   23%
        public int AddDigits2(int num)
        {
            var sum = 0;
            while (true)
            {
                sum = sum + num % 10;
                num = num / 10;
                if (num == 0)
                {
                    num = sum;
                    sum = 0;
                    if (num < 10) break;
                }
            }
            return num;
        }


        // Math way   100%   7.69%
        public int AddDigits3(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            else if (num % 9 == 0)
            {
                return 9;
            }
            return num % 9;
        }
    }
}
