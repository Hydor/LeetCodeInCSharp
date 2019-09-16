

namespace LeetCode.ListPro
{
    class P206ReverseLinkedList
    {

        public class ListNode
        {
             public int val;
             public ListNode next;
             public ListNode(int x) { val = x; }
         }


        // Approach 1 : Recursive
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode p = ReverseList(head.next);
            head.next.next = head;
            head.next = null;
            return p;
        }

        // Approach 2 : Iterative
        public ListNode ReverseList2(ListNode head)
        {
            ListNode pre = null;
            var curr = head;
            while (curr.next != null)
            {
                var temp = curr.next;
                curr.next = pre;
                pre = curr;
                curr = temp;
            }
            return pre;
        }


    }
}
