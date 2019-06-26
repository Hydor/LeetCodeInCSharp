
namespace LeetCode.BinarySearch
{
   
    class P278_FirstBadVersion
    {
        // test case
        static int Target = 5;
        public static bool IsBadVersion(int version){
            return version >= Target;
        }

        //  97.94%  98.48%
        public static int FirstBadVersion(int n) {
            if (n < 1) {
                return -1;
            }
            var start = 1;
            var end = n;
            var mid = 1;
            while (start + 1 < end)
            {
                mid = start + (end - start) / 2;
                if (start == mid || end == mid)
                {
                    break;
                }
                else if (IsBadVersion(mid))
                {
                    end = mid;
                }
                else {
                    start = mid;
                }
            }
            if (IsBadVersion(start))
            {
                return start;
            }
            if (IsBadVersion(end))
            {
                return end;
            }
            return 0;
        }

    }
}
