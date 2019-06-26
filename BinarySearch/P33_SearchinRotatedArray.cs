
namespace LeetCode.BinarySearch
{
    class P33_SearchinRotatedArray
    {
        public int Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }
            var start = 0;
            var end = nums.Length - 1;
            var mid = 0;
            var deviation = 0;
            for (var i = 0; i <= end; i++)
            {
                if (nums[0] > nums[i])
                {
                    deviation = i; break;
                }
            }
            if (target == nums[0])
            {
                return 0;
            }
            else if (target < nums[0])
            {
                start = deviation;
            }
            else if (deviation > 0)
            {
                end = deviation - 1;
            }


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
                else
                {
                    start = mid;
                }
            }
            if (nums[start] == target)
            {
                return start;
            }
            if (nums[end] == target)
            {
                return end;
            }
            return -1;
        }
    }
}
