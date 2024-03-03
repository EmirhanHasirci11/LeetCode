namespace RemoveNthNodeFromEndofList
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class Solution
    {        
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new(0, head);
            ListNode slow = dummy, fast = dummy;
            for (int i = 0; i < n; i++)
            {
                fast = fast.next;
            }
            while (fast?.next != null)
            {
                slow = slow.next;
                fast = fast.next;
            }
            slow.next = slow.next.next;

            return dummy.next;
        }
    }
    }
}