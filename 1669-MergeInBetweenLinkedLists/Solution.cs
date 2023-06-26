namespace MergeInBetweenLinkedLists
{
    internal class Solution
    {
        public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
        {
            ListNode head = list1;
            int temp = 0;
            while (list1 != null && temp != a - 1)
            {
                list1 = list1.next;
                temp++;
            }
            temp = a;
            ListNode next = list1.next;
            list1.next = list2;
            while (next != null && temp != b + 1)
            {
                next = next.next;
                temp++;
            }
            while (list2.next != null)
                list2 = list2.next;

            list2.next = next;
            return head;
        }

    }
}