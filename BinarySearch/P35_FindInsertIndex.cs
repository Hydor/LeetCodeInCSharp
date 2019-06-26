
namespace LeetCode.BinarySearch
{
    class P35_FindInsertIndex
    {
        // BUG: 1. if the condition for stop loop is (start < end), it will cause Time Limit Exceeded , Endless loop
        //      2. if conditions setting need pay attention to Interval(区间)
        public static int SearchInsert(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            var start = 0;
            var end = nums.Length - 1;
            var mid = 0;
            while (start + 1 < end)
            {
                mid = (start + end) / 2;
                
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    end = mid;
                }
                else { start = mid; }
            }
            if (nums[start] == target)
            {
                return start;
            }
            if (nums[end] == target)
            {
                return end;
            }
            if (nums[start] > target)
            {
                return start;
            }
            if (nums[end] < target)
            {
                return end + 1;
            }
            if (nums[start] < target)
            {
                return start + 1;
            }
            return 0;
        }




        //Brute Force
        public int SearchInsert2(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    return i;
                }
                else if (nums[i] > target)
                {
                    return i;
                }

            }
            return nums.Length;
        }
    }
}
