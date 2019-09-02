using System;
using System.Collections.Generic;

namespace LeetCode.Array
{
    class P349_IntersectionTwoArrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            var res = new int[Math.Min(nums1.Length, nums2.Length)];
            var index = 0;
            if (nums1 == null || nums2 == null)
            {
                return res;
            }
            var dic = new Dictionary<int, int>();
            foreach (var n1 in nums1)
            {
                if (!dic.ContainsKey(n1))
                {
                    dic.Add(n1, 1);
                }
            }
            foreach (var n2 in nums2)
            {
                if (dic.ContainsKey(n2) && dic[n2] == 1)
                {
                    dic[n2] = 2;
                    res[index++] = n2;
                }
            }
            var realres = new int[index];
            for (var i = 0; i < index; i++)
            {
                realres[i] = res[i];
            }
            return realres;
        }
    }
}
