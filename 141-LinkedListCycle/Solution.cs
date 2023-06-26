namespace LinkedListCycle
{
    internal class Solution
    {
        public bool HasCycle(ListNode head)
        {
            ListNode slowest = head;
            ListNode fastest = head;
            while (fastest != null && fastest.next != null)
            {
                slowest = slowest.next;
                fastest = fastest.next.next;
                if (slowest == fastest)
                    return true;

            }
            return false;
        }
    }
}