// Given the head of a singly linked list, return true if it is a palindrome or false otherwise.

// Example 1:
// 1 -> 2-> 2-> 1
// Input: head = [1,2,2,1]
// Output: true

//Example 2:
// Input: head = [1,2]
// Output: false

namespace Assignment_12._1._2
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
            IsPalindrome(new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(1)))));

        }

        public static bool IsPalindrome(ListNode head)
        {
            // Initialize two pointers, slow and fast, to find the middle of the linked list
            ListNode slow = head;
            ListNode fast = head;
            // Move the fast pointer twice as fast as the slow pointer
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            // Reverse the second half of the linked list
            ListNode prev = null;
            while (slow != null)
            {
                ListNode nextTemp = slow.next;
                slow.next = prev;
                prev = slow;
                slow = nextTemp;
            }
            // Compare the first half and the reversed second half of the linked list
            ListNode left = head;
            ListNode right = prev;
            while (right != null)
            {
                if (left.val != right.val)
                {
                    return false; // Not a palindrome
                }
                left = left.next;
                right = right.next;
            }
            return true; // Is a palindrome
        }
    }
}
