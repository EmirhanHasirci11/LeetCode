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

        static void Main(string[] args)
        {
            ListNode Head= new ListNode(1);
            Head.next = new ListNode(2);
            Head.next.next = new ListNode(3);
            Head.next.next.next = new ListNode(4);
            Head.next.next.next.next = new ListNode(5);
            ListNode a= RemoveNthFromEnd(Head,2);
        }
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            Dictionary<int, ListNode> map = new();
            ListNode current = head;
            int count =1;
            while (current != null)
            {
                map[count++]=current;               
                current= current.next;
            }
            ListNode behind = map.ContainsKey(map.Count-n)!=null? map[map.Count - n]:head;
            ListNode after = map.ContainsKey(map.Count - n + 2) != null ? map[map.Count - n + 2] : null;
            behind.next = after;
            return head;
        }
    }
}