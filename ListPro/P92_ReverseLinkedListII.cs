using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ListPro
{
        public class ListNode
       {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
  }

    class P92_ReverseLinkedListII
    {

        public  static ListNode ReverseBetween(ListNode head, int m, int n)
        {
            if (head == null || head.next == null || m == n) return head;

            ListNode prev = null;

            var curr = head;

            while (m > 1)
            {
                prev = curr;
                curr = curr.next;
                m--;
                n--;
            }

            ListNode oHead = prev;  // fixed position
            ListNode oTail = curr;



            ListNode temp = null;
            while (n > 0) //
            {
                temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
                n--;
            }

            if (oHead != null)  //if reverse from first element
            {
                oHead.next = prev;
            }
            else
            {
                head = prev;
            }
            oTail.next = curr;



            return head;
        }


    }
}
