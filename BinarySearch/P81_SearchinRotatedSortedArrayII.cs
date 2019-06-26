using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearch
{
    class P81_SearchinRotatedSortedArrayII
    {
        //Binary Search  
        public static bool Search(int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return false;
            }
            var start = 0;
            var end = nums.Length - 1;
            var mid = 0;
            var deviation = 0;
            deviation = System.Array.IndexOf(nums, nums.Min());    // coner case    131111   it has deviation
            if (deviation == 0)
            {
                var max = System.Array.IndexOf(nums, nums.Max());
                if (max != end) deviation = max + 1;
            }

            if (nums[0] == target)
            {
                return true;
            }
            else if (nums[0] > target)
            {
                start = deviation;
            }
            else if (nums[0] < target  && deviation != 0)  // *************** when  deviation = 0  It shouldn't change end
            {
                end = deviation;
            }
             
            while (start + 1 < end)
            {
                mid = (start + end) / 2;
                if (nums[mid] == target)
                {
                    return true;
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
            return (nums[start] == target || nums[end] == target);

        }


        //Brute Force
        public static bool Search2 (int[] nums, int target)
        {
            if (nums == null || nums.Length == 0)
            {
                return false;
            }
            foreach (var i in nums)
            {
                if (i == target)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
