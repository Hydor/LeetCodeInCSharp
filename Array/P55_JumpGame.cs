using System.Linq;

namespace LeetCode.Array
{
    class P55_JumpGame
    {
        //Greedy    78.75%    97.30%
        public bool CanJump(int[] nums)
        {
            int lastPos = nums.Count() - 1;
            for (int i = nums.Count() - 1; i >= 0; i--)
            {
                if (i + nums[i] >= lastPos)
                {
                    lastPos = i;
                }
            }
            return lastPos == 0;
        }
    }
}
