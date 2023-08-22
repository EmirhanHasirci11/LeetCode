namespace InsertGreatestCommonDivisorsinLinkedList
{
    internal class Solution
    {        
        public ListNode InsertGreatestCommonDivisors(ListNode head)
        {
            ListNode headDummy= head;
            ListNode current = headDummy.next;
            while(current != null) 
            {
                int gcdValue = GCD(headDummy.val, current.val);
                ListNode node = new(gcdValue,current);
                headDummy.next = node;
                headDummy= current;
                current = current.next;
            }
            return head;
        }
        public int GCD(int a, int b)
        {
            if (b > a)
                return GCD(b, a);
            if (a % b == 0)
                return b;
            return GCD(b, a % b);
        }
    }
}