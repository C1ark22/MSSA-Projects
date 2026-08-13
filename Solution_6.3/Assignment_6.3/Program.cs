using System.Collections;
using System.Reflection;
using System.Reflection.Metadata;
using System.Xml.Linq;
using static Assignment_6._3.Program;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment_6._3
{
    class CallNode
    {
        public string CallerName { get; set; }
        public string PhoneNumber { get; set; }
        public CallNode Next { get; set; }

        public CallNode(string callerName, string phoneNumber)
        {
            CallerName = callerName;
            PhoneNumber = phoneNumber;
            Next = null;
        }
    }
    class Program
    {
        // Queue class definition
        public class CallQueue
        {
            private CallNode front;
            private CallNode rear;
            private int count;

            public CallQueue()
            {
                front = rear = null;
            }

            // enqueue operation
            public void Enqueue(string callerName, string phoneNumber)
            {
                var newNode = new CallNode(callerName, phoneNumber);

                if (isEmpty()) 
                {
                    front = rear = newNode;
                } else
                {
                    rear.Next = newNode;
                    rear = newNode;
                }

                count++;
                Console.WriteLine($"Call from {callerName} ({phoneNumber}) added to the queue");
            }

            // dequeue operation
            public void Dequeue()
            {
                if (isEmpty())
                {
                    Console.WriteLine("No calls in queue.");
                    return;
                }

                Console.WriteLine($"Attending call from {front.CallerName} ({front.PhoneNumber}).");
                front = front.Next;

                if (front == null) rear = null;

                count--;
            }

            // peek at the next call
            public void Peek()
            {
                if (isEmpty())
                {
                    Console.WriteLine("No calls in queue.");
                    return;
                }

                Console.WriteLine($"Next Call: {front.CallerName} ({front.PhoneNumber}).");
            }

            // check if the queue is empty
            public bool isEmpty()
            {
                return front == null;
            }

            // Display all calls in the queue
            public void DisplayQueue()
            {
                if (isEmpty())
                {
                    Console.WriteLine("No calls in queue.");
                    return;
                }

                Console.WriteLine("Current Call Queue:");

                var temp = front;
                while(temp != null)
                {
                    Console.WriteLine($"- {temp.CallerName} ({temp.PhoneNumber})");
                    temp = temp.Next;
                }
            }

        };
        static void Main(string[] args)
        {

            CallQueue callQueue = new CallQueue();

            // Sample operations
            callQueue.Enqueue("Alice", "555-1234");
            callQueue.Enqueue("Bob", "555-5678");
            callQueue.Enqueue("Charlie", "555-8765");

            callQueue.DisplayQueue();
            callQueue.Peek();

            callQueue.Dequeue();
            callQueue.DisplayQueue();

            callQueue.Dequeue();
            callQueue.Dequeue();
            callQueue.Dequeue(); // Attempt to dequeue from empty queue
        
        }
    }
}
