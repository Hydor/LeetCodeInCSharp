using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    class P41_FirstMissingPositive
    {

        // Another Array   --  82.70%   &  76.36%
        public int FirstMissingPositive(int[] nums)
        {
            var NewArr = new int[nums.Count()+2]; 
            foreach (var i in nums)
            {
                if (i > 0 && i <= nums.Count()) { NewArr[i] = 1; }
            }
            for (var i = 1; i < NewArr.Count(); i++)
            {
                if (NewArr[i] < 1) return i;
            }
            return 0;

        }
    }
}
