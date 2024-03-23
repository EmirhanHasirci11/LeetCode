namespace ReorderList
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
        public void ReorderList(ListNode head)
        {
            ListNode midNode = MidNode(head);
            ListNode nextToMid = midNode.next;
            midNode.next = null;
            ListNode p2 = Reverse(nextToMid);

            ListNode p1 = head, p1Next;
            while (p1 != null && p2 != null)
            {
                p1Next = p1.next;
                p1.next = p2;

                p1 = p2;
                p2 = p1Next;
            }
        }
        public ListNode MidNode(ListNode head)
        {
            ListNode fast = head, slow = head;
            while (fast.next != null && fast.next.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            return slow;
        }

        public ListNode Reverse(ListNode head)
        {
            ListNode curr = head, prev = null, next = null;
            while (curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            return prev;
        }
    }
}
