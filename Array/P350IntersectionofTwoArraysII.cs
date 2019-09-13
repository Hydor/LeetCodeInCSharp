using System;
using System.Collections.Generic;

namespace LeetCode.Array
{
    class P350IntersectionofTwoArraysII
    {

        // Follow Up 1: if array is sorted 
        //              binary search
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            var minLength = Math.Min(nums1.Length, nums2.Length);
            var result = new int[minLength];
            var index = 0;
            if (minLength == 0)
            {
                return result;
            }
            var dict = new Dictionary<int, int>();  //<number, count>;var 
            if (nums1.Length <= nums2.Length)
            {
                dict = StoreToDictionary(nums1);
                foreach (var i in nums2)
                {
                    if (dict.ContainsKey(i) && dict[i] > 0)
                    {
                        result[index++] = i;
                        dict[i]--;
                    }
                }
            }
            else
            {
                dict = StoreToDictionary(nums2);
                foreach (var i in nums1)
                {
                    if (dict.ContainsKey(i) && dict[i] > 0)
                    {
                        result[index++] = i;
                        dict[i]--;
                    }
                }
            }
            System.Array.Resize(ref result, index);
            return result;
        }

        public Dictionary<int, int> StoreToDictionary(int[] nums)
        {
            var dict = new Dictionary<int, int>();  //<number, count>;
            foreach (var i in nums)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                else
                {
                    dict.Add(i, 1);
                }
            }
            return dict;

        }
    }
}
