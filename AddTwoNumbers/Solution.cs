namespace AddTwoNumbers
{
    internal class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = new();
            ListNode current = head;
            int carry = 0;
            while (l1 != null || l2 != null || carry == 1)
            {
                int sum = 0;
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
                sum += carry;
                carry = sum / 10;
                ListNode currentSum = new(sum % 10);
                current.next = currentSum;
                current = current.next;
            }
            return head.next;

        }
    }
}