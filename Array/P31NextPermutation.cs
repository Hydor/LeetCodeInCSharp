using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    class P31NextPermutation
    {
        public void NextPermutation(int[] nums)
        {
            if (nums == null || nums.Length == 0) return;

            var firstDecreaseIndex = -1;
            var firstDecreaseNum = -1;
            for (var i = nums.Length - 1; i > 0; i--)
            {
                if (nums[i] > nums[i - 1])
                {
                    firstDecreaseIndex = i - 1;
                    firstDecreaseNum = nums[i - 1];
                    break;
                }
            }
            if (firstDecreaseIndex >= 0)
            {
                // find the Replace Number 
                // that is the number behind firstDecreaseNum && last larger than it
                for (var i = firstDecreaseIndex + 1; i < nums.Length; i++)
                {
                    if (i == nums.Length - 1 || firstDecreaseNum >= nums[i + 1])       // **********    >=    include the equal case
                    {
                        nums[firstDecreaseIndex] = nums[i];
                        nums[i] = firstDecreaseNum;
                        break;
                    }
                }
            }

            // we reverse the rest array 
            // if the firstDecreaseIndex dose not exist reverse all array
            int start = firstDecreaseIndex + 1, end = nums.Length - 1, temp = 0;
            while (start < end)
            {
                temp = nums[start];
                nums[start++] = nums[end];
                nums[end--] = temp;
            }
        }
    }
}
