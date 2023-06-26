namespace MergeTwoSortedLists
{   
    internal class Solution
    {     
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode mergedList = new();
            ListNode head = mergedList;
            while (list1 is not null && list2 is not null )
            {
                if (list1.val < list2.val)
                {
                    mergedList.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    mergedList.next = list2;
                    list2 = list2.next;
                }
                
                mergedList=mergedList.next;
            }

            mergedList.next = list1 ?? list2;

            return head.next;
        }
    }
}