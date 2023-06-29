namespace DesignLinkedList
{
    internal class Solution
    {       
        public class ListNode
        {
            public int value;
            public ListNode next;
            public ListNode(int val, ListNode next)
            {
                this.value = val;
                this.next = next;
            }
            public ListNode(int val)
            {
                this.value = val;
            }
        }

        public class MyLinkedList
        {
            public ListNode Head;

            public MyLinkedList()
            {

            }

            public int Get(int index)
            {
                ListNode current = FindIndex(index);
                if (current == null)
                    return -1;
                return current.value;
            }

            public void AddAtHead(int val)
            {
                ListNode temp = new ListNode(val, Head);
                Head = temp;
            }

            public void AddAtTail(int val)
            {
                if (Head == null)
                    Head = new ListNode(val);
                else
                {

                    ListNode current = Head;
                    while (current.next != null)
                    {
                        current = current.next;
                    }
                    current.next = new ListNode(val);
                }
            }

            public void AddAtIndex(int index, int val)
            {
                if (index == 0)
                    Head = new ListNode(val, Head);
                else
                {
                    ListNode current = FindIndex(index - 1);
                    if (current == null)
                    {
                        current= new ListNode(val);
                    }
                    current.next = new ListNode(val, current.next);
                }
            }

            public void DeleteAtIndex(int index)
            {
                if (index == 0)
                {
                    if(Head!=null)
                    Head = Head.next;
                }
                else {
                    ListNode current = FindIndex(index - 1);
                    if(current!=null)
                        if(current.next != null)
                    current.next=current.next.next;
                }

            }

            public ListNode FindIndex(int index)
            {                
                ListNode current = Head;
                for (int i = 0; i < index; i++)
                {
                    if (current != null)
                    {

                    current = current.next;
                    }
                }
                return current;
            }
        }

    }
}