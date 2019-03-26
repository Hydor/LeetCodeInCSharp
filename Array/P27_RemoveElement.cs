using System.Linq;

namespace LeetCode
{
    class P27_RemoveElement
    {

        //Approach 1: Two Pointers

        public static int RemoveElement(int[] nums, int val)
        {
            int pointer = 0;
            for (int i = 0; i < nums.Count(); i++)
            {
                if (nums[i] != val) 
                {
                    nums[pointer] = nums[i];
                    pointer++;
                }
                
            }
            return pointer;
        }


        //  Approach 2: Two Pointers - move the END element to the position
        public int RemoveElement2(int[] nums, int val)
        {
            int n = nums.Count();
            for (int i = 0; i < n; i++)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[n - 1];
                    n--;
                    i--;
                }
            }
            return n;
        }

    }
}
