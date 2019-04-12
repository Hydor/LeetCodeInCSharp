using System;
using System.Linq;

namespace LeetCode.Array
{
    class P11_ContainerWithMostWater
    {
        //Two Pointer       O(n)         92.90%    16.79%
        public int MaxArea(int[] height)
        {
            var leftIndex = 0;
            var rightIndex = height.Count() - 1;
            var max = 0;
            while (leftIndex != rightIndex)
            {
                max = Math.Max(max, (rightIndex - leftIndex) * Math.Min(height[leftIndex], height[rightIndex]));
                if (height[leftIndex] > height[rightIndex]) rightIndex--;
                else { leftIndex++; }
            }
            return max;
        }
    }
}
