using System.Linq;

namespace LeetCode.Array
{
    public class P189_RotateArray
    {
        // Solution 1: Another Array   --Runtime: faster than 73.91% , Memory : less than 50.00% 
        public static void Rotate(int[] nums, int k)
        {
            if (nums.Count() == 0) return;
            k = k % nums.Count();
            if (k == 0) return;
            var n = nums.Count() - k;
            var biger = n > k ? n : k;
            var smaller = n < k ? n : k;
            var newNums = new int[n];
            var j = 0;
            for (int i = 0; i < nums.Count(); i++)
            {
                    if (i < k )
                    {
                        if(i< smaller) newNums[i] = nums[i];
                        nums[i] = nums[(n + i)% nums.Count()];
                    }                    
                    else
                    {
                        if (i < biger) newNums[i] = nums[i];
                        nums[i] = newNums[j];
                        j++;
                    }      
            }

        }

        //Solution 2: Recursion ---Faster than 73.27% , less than 6.67% 

        public static void Rotate2(int[] nums, int k)
        {
            if (nums.Count() <= 1 || k==0 || nums.Count()==k) return;
            k = k % nums.Count();
            var loopSize =   1 ;
            if (nums.Count() % k == 0)
            { loopSize = k; }
            else if (nums.Count() % (nums.Count()- k) == 0)
            { loopSize = nums.Count() - k; }
           
             
            for (int i = 0; i < loopSize; i++)
            {
                var tempNumber = nums[i];            
                GetNewNumberByIndex(nums, k, i, tempNumber, i);
            }
        }

        static void GetNewNumberByIndex(int[] nums, int k, int index, int tempNumber, int firstIndex)
        {
            var nextIndex = index >= k ? index - k: index + nums.Count() - k;            
            if (nextIndex == firstIndex)
            {
                nums[index] = tempNumber;
            }
            else
            {
                nums[index] = nums[nextIndex];
                GetNewNumberByIndex(nums, k, nextIndex, tempNumber, firstIndex);
            }            
            return;
        }
     }
}
