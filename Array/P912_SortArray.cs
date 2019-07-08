
namespace LeetCode.Array
{
    class P912_SortArray
    {
        public static int[] SortArray(int[] nums)
        {
            if (nums == null || nums.Length <= 1)
            {
                return nums;
            }
            QuickSortHelper(nums, 0, nums.Length - 1);
            return nums;

        }
        public static void QuickSortHelper(int[] nums, int start, int end)
        {
            if (start >= end) return;

            int leftP = start - 1;
            int rightP = end;
            while (true)
            {

                while (nums[++leftP] < nums[end]) ;
                while (nums[--rightP] > nums[end] && rightP > 0) ;
                if (leftP >= rightP) break;
                Swap(nums, rightP, leftP);
            }
            Swap(nums, leftP, end);

            QuickSortHelper(nums, start, leftP - 1);
            QuickSortHelper(nums, leftP + 1, end);
        }

        public static void Swap(int[] array, int i, int j)
        {
            var e = array[i];
            array[i] = array[j];
            array[j] = e;
        }

    }
}
