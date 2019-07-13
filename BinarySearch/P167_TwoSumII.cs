using System;
using System.Linq;

namespace LeetCode.BinarySearch
{
    class P167_TwoSumII
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            var res = new int[2];
            if (numbers.Count() <= 1)
            {
                return res;
            }

            for (var i = 0; i < numbers.Count(); i++)
            {
                var searchResult = BinarySearch(numbers, target - numbers[i]);
                if (searchResult > 0 && searchResult != i)
                {

                    res[0] = Math.Min(i, searchResult) + 1;
                    res[1] = Math.Max(i, searchResult) + 1;
                }
            }
            return res;
        }
        //if find return index, if not return -1
        public int BinarySearch(int[] nums, int t)
        {
            var start = 0;
            var end = nums.Count() - 1;
            var mid = 0;
            while (start + 1 < end)
            {
                mid = start + (end - start) / 2;
                if (nums[mid] == t)
                {
                    return mid;
                }
                else if (nums[mid] > t)
                {
                    end = mid;
                }
                else
                {
                    start = mid;
                }
            }
            if (nums[start] == t) return start;
            if (nums[end] == t) return end;
            return -1;
        }
    }
}
