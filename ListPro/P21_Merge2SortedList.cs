using System;

namespace LeetCode.ListPro
{
    class P21_Merge2SortedList
    {
        //Merge to new   100%    5%
        public static ListNode MergeTwoLists2(ListNode l1, ListNode l2)
        {
            var first = new ListNode(-1);

            ListNode prev = first;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    prev.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    prev.next = l2;
                    l2 = l2.next;
                }
                prev = prev.next;
            }

            // exactly one of l1 and l2 can be non-null at this point, so connect
            // the non-null list to the end of the merged list.
            prev.next = l1 == null ? l2 : l1;

            return first.next;
        }


        // Recursion   100%   12.9%
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            else if (l2 == null)
            {
                return l1;
            }
            else if (l1.val < l2.val)
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeTwoLists(l1, l2.next);
                return l2;
            }

        }
        

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
