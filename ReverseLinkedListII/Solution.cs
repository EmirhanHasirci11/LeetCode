namespace ReverseLinkedListII
{
    public class Solution
    {
        
        public  ListNode ReverseBetween(ListNode head, int left, int right)
        {
            ListNode current = new(0,head);
            ListNode prev= current; 
            for(int i=0;i<left-1;i++)
                prev=prev.next;
            ListNode startPos = prev.next;
            ListNode next =startPos.next;
            for(int i = 0; i < right - left; i++)
            {
                startPos.next = next.next;
                next.next= prev.next;
                prev.next = next;
                next=startPos.next;
            }
            return current.next;
        }

    }
}