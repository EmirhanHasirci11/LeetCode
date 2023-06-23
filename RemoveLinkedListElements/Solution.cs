namespace RemoveLinkedListElements
{
    internal class Program
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode current = head;
            ListNode prev = null;

            while (current != null)
            {
                if (current.val == val)
                {
                    if (prev != null)
                        prev.next = current.next;
                    else
                        head = head.next;
                }
                else
                    prev = current;
                current = current.next;
            }
            return head;
        }
    }
}