using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.ListPro
{
    class P2_TwoSum
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var result = new ListNode(0);    // new ListNode need an ininitial int
            var head = result;    // ****** save the head for fanal return  ******
            var carry = 0;
            var n1 = 0;
            var n2 = 0;
            var sum = 0;
            while (l1 != null || l2 != null || carry > 0)     // carry > 0 
            {
                result.next = new ListNode(0);
                result = result.next;
                n1 = l1 != null ? l1.val : 0;    
                n2 = l2 != null ? l2.val : 0;
                sum = n1 + n2 + carry;
                result.val = sum % 10;
                carry = sum / 10;

                l1 = l1 != null ? l1.next : null;   //  if not check , will cus NullReferenceException
                l2 = l2 != null ? l2.next : null;
            }
            return head.next;
        }
    }
}
