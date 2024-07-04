namespace RemoveDuplicatesfromSortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode();
            ListNode secondElement = new ListNode();
            ListNode thirdElement = new ListNode();
            ListNode fourthElement = new ListNode();
            ListNode fifthElement = new ListNode();

            head.val = 1;
            head.next = secondElement;
            secondElement.val = 1;
            secondElement.next = thirdElement;
            thirdElement.val = 2;
            thirdElement.next = fourthElement;

            fourthElement.val = 3;
            fourthElement.next = fifthElement;
            fifthElement.val = 3;
            fifthElement.next = null;

          


            ListNode start = Program.DeleteDuplicates(head);

            while(start != null)
            {
                Console.WriteLine(start.val);
                start = start.next;

            }

            Console.ReadLine();
        }

        public static ListNode DeleteDuplicates(ListNode head)
        {

            if (head == null)
                return head;

            ListNode current = head;

            while (current.next !=null)
            {
                if(current.val == current.next.val)
                {
                    ListNode temp = current.next;
                    current.next = temp.next;
                }
                else
                {
                    current = current.next;
                }

            }

            return head;

        }


        //Definition for singly-linked list.
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

    }
}
