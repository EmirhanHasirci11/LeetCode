namespace LinkedListRandomNode
{
    internal class Solution
    {
        private Random random;
        private ListNode head;

        public Solution(ListNode head)
        {
            this.head = head;
            this.random = new Random();
        }

        public int GetRandom()
        {
            ListNode current = head;
            int count = 0;
            while (current != null)
            {
                count++;
                current = current.next;
            }
            current = head;
            int temp = random.Next(count);
            count = 0;
            while (current != null && count != temp)
            {

                current = current.next;
                count++;
            }

            return current.val;
        }
    }
}