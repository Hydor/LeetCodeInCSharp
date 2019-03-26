using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    class P80_RemoveDuplicates2
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Count() == 0) return 0;
            var pointer = 0;
            var currentNumber = nums[0];
            var curNumCount = 0;

            for (int i = 0; i < nums.Count(); i++)
            {
                if (nums[i] == currentNumber && curNumCount >= 2)
                {
                    curNumCount++;

                }
                else if (nums[i] == currentNumber && curNumCount < 2)
                {
                    curNumCount++;
                    nums[pointer] = nums[i];
                    pointer++;
                }
                else
                {
                    curNumCount = 1;
                    nums[pointer] = nums[i];
                    pointer++;
                }
                currentNumber = nums[i];
            }

            return pointer;
        }
    }
}
