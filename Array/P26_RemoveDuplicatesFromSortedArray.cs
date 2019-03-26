using System.Linq;

namespace LeetCode.Array
{
    public class P26_RemoveDuplicatesFromSortedArray
    {

        // Solution: Two Pointer

        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Count() == 0) return 0;
            var pointer = 1;
            var currentNumber = nums[0];
            for (var i = 1; i < nums.Count(); i++)
            {
                if (nums[i] != currentNumber)
                {
                    nums[pointer] = nums[i];
                    pointer++;
                    currentNumber = nums[i];
                }
            }
            return pointer;
        }
    }
}
