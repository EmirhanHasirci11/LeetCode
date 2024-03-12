namespace RemoveZeroSumConsecutiveNodesfromLinkedList
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
        public ListNode RemoveZeroSumSublists(ListNode head)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            Dictionary<int, ListNode> prefixSumToNode = new();
            int prefixSum = 0;
            for (ListNode current = dummy; current != null; current = current.next)
            {
                prefixSum += current.val;
                if (prefixSumToNode.ContainsKey(prefixSum))
                {
                    ListNode prev = prefixSumToNode[prefixSum];
                    ListNode toRemove = prev.next;
                    int p = prefixSum + (toRemove != null ? toRemove.val : 0);
                    while (p != prefixSum)
                    {
                        prefixSumToNode.Remove(p);
                        toRemove = toRemove.next;
                        p += (toRemove != null ? toRemove.val : 0);
                    }
                    prev.next = current.next;
                }
                else
                {
                    prefixSumToNode[prefixSum] = current;
                }
            }
            return dummy.next;
        }
    }
}