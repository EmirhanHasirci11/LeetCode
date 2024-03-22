using System.Text;

namespace PalindromeLinkedList
{
    internal class Solution
    {
        public bool IsPalindrome(ListNode head)
        {
            StringBuilder stringBuilder = new();

            while (head != null)
            {
                stringBuilder.Append(head.val);
                head = head.next;
            }
            string x = stringBuilder.ToString();

            return x.Reverse().SequenceEqual(x);
        }
    }
}