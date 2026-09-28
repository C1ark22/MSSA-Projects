//Given the head of a linked list and an integer val, remove all the nodes of the linked list
//that has Node.val == val, and return the new head.

//Example 1:
// 1 -> 2 -> 6 -> 3 -> 4 -> 5 -> 6
//              |
//              V
// 1 -> 2 -> 3 -> 4 -> 5

//Input: head = [1, 2, 6, 3, 4, 5, 6], val = 6

//Output: [1, 2, 3, 4, 5]

//Example 2:

//Input: head = [], val = 1

//Output: []

//Example 3:

//Input: head = [7, 7, 7, 7], val = 7

//Output: []

namespace Assignment_12._2._1
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
    public class Program
    {
        static void Main(string[] args)
        {
            // Create the linked list: [1, 2, 6, 3, 4, 5, 6]
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(6);
            head.next.next.next = new ListNode(3);
            head.next.next.next.next = new ListNode(4);
            head.next.next.next.next.next = new ListNode(5);
            head.next.next.next.next.next.next = new ListNode(6);

            int val = 6;

            // Remove every node whose value is 6.
            head = RemoveElements(head, val);

            // Print the remaining values.
            ListNode current = head;

            while (current != null)
            {
                Console.Write(current.val + " ");
                current = current.next;
            }

            Console.WriteLine();

        }
        public static ListNode RemoveElements(ListNode head, int val)
        {
            // Create a dummy node to handle edge cases
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode current = dummy;

            while (current.next != null)
            {
                if (current.next.val == val)
                {
                    // Skip the node with the target value
                    current.next = current.next.next;
                }
                else
                {
                    // Move to the next node
                    current = current.next;
                }
            }
            return dummy.next; // Return the new head of the list
        }

    }
}
