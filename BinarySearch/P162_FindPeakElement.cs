

namespace LeetCode.BinarySearch
{
    class P162_FindPeakElement
    {
        public int FindPeakElement(int[] nums)
        {
            if (nums == null)
            {
                return -1;
            }
            if (nums.Length == 1)
            {
                return 0;
            }
            var start = 0;
            var end = nums.Length - 1;
            var mid = 0;
            while (start + 1 < end)
            {
                mid = (start + end) / 2;
                var leftNums = (mid - 1 < 0) ? int.MinValue : nums[mid - 1];
                var rightNums = (mid + 1 == nums.Length) ? int.MaxValue : nums[mid + 1];
                if (nums[mid] > nums[mid - 1] && nums[mid + 1] < nums[mid])  // pick
                {
                    return mid;
                }
                if (nums[mid] > nums[mid - 1] && nums[mid + 1] > nums[mid]) // increase case
                {
                    start = mid;
                }
                else if (nums[mid] < nums[mid - 1] && nums[mid + 1] < nums[mid]) //decrease case
                {
                    end = mid;
                }
                else   // Valley bottom case  ********************** 
                {
                    end = mid;
                }
            }
            if (start == 0 && nums[start] > nums[start + 1])  //edge case return first
            {
                return start;
            }
            if (end == nums.Length - 1 && nums[end] > nums[end - 1])  //edge case return first
            {
                return end;
            }
            if (nums[start] > nums[start - 1] && nums[start + 1] < nums[start])
            {
                return start;
            }

            if (nums[end] > nums[end - 1] && nums[end + 1] < nums[end])
            {
                return end;
            }
            return -1;
        }
    }
}
