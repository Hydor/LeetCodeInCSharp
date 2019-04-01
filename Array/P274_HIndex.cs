using System.Linq;

namespace LeetCode.Array
{
    class P274_HIndex
    {

        //Sorting    88.61%  83.33%
        public static int HIndex(int[] citations)
        {
            BaseClass.QuickSort.QuickSortArray(citations);
            int i = 0;
            while (i < citations.Count() && citations[citations.Count() - 1 - i] > i)
            {
                i++;
            }
            return i;
        }

        // System.Array.Sort    88.61%   16.67%
        public static int HIndex2(int[] citations)
        {
            if (citations.Count()==0){return 0;}
            System.Array.Sort(citations);
            int i = 0;
            while (i < citations.Count() && citations[citations.Count() - 1 - i] > i)
            {
                i++;
            }
            return i;
        }


    }
}
