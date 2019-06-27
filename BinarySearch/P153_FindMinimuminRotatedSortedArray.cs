using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearch
{
    class P153_FindMinimuminRotatedSortedArray
    {
        //Binary Search : note the edge situation   like    61234    34561   
        public int FindMin(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            var start = 1;
            var end = nums.Length - 2;
            if (nums.Length == 1 || nums[0] < nums[end + 1])
            {
                return nums[0];
            }
            if (nums[start] < nums[end] && nums[start] > nums[0])
            {
                return nums[end + 1];
            }

            var mid = 0;
            while (start + 1 < end)
            {
                mid = start + (end - start) / 2;
                if (nums[mid] > nums[mid + 1] && nums[mid] < nums[mid - 1])
                {
                    return nums[mid];
                }

                else if (nums[mid] > nums[start] && nums[mid] > nums[0])
                {
                    start = mid;
                }
                else
                {
                    end = mid;
                }

            }
            if (nums[start] > nums[0] && nums[end] > nums[0]) return nums[nums.Length - 1];
            //Console.WriteLine(start);
            // Console.WriteLine(end);
            return nums[start] > nums[end] ? nums[end] : nums[start];
        }


        //Brute Force
        public int FindMin2(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }
            if (nums.Length == 1 || nums[0] < nums[nums.Length - 1])
            {
                return nums[0];
            }
            for (var i = nums.Length - 1; i > 0; i--)
            {
                if (nums[i] < nums[i - 1]) return nums[i];
            }
            return 0;
        }

    }
}
