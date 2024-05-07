namespace DoubleaNumberRepresentedasaLinkedList
{
    internal class Solution
    {
        public ListNode DoubleIt(ListNode head)
        {
            var node = head = new ListNode(0, head);
            for (; node.next != null; node = node.next)
            {
                node.val += node.next.val * 2 / 10;
                node.next.val = node.next.val * 2 % 10;
            }
            return head.val == 0 ? head.next : head;
        }
    }
}
