namespace Assignment_11._2._2
{
    using System;

    public class ListNode
    {
        public int val;
        public ListNode? next;

        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode? ReverseList(ListNode? head)
        {
            ListNode? previous = null;
            ListNode? current = head;

            while (current != null)
            {
                // Save the next node before changing the connection.
                ListNode? nextNode = current.next;

                // Reverse the connection so it points backward.
                current.next = previous;

                // Move previous and current forward.
                previous = current;
                current = nextNode;
            }

            // Previous is now the head of the reversed list.
            return previous;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // Create the linked list: 1, 2, 3, 4, 5.
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);

            Solution solution = new Solution();
            ListNode? reversedHead = solution.ReverseList(head);

            // Walk through the reversed list and print each value.
            ListNode? current = reversedHead;

            while (current != null)
            {
                Console.Write(current.val + " ");
                current = current.next;
            }
        }
    }
}
