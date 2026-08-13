namespace Assignment_6._2._1
{
    class MyStack
    {
        private int[] items;
        private int top;

        public MyStack(int size)
        {
            items = new int[5];

            // -1 means stack is empty
            top = -1;
        }
        public void Push(int item)
        {
            // check if the array is full
            if (top == items.Length - 1)
            {
                Console.WriteLine("Stack is full");
                return;
            }
            top++;

            items[top] = item;
        }
        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            int value = items[top];

            top--;

            return value;
        }
        public int Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            return items[top];
        }
        public bool IsEmpty()
        {
            return top == -1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack myStack = new MyStack(5);

            myStack.Push(5);
            Console.WriteLine($"My Stack contains: {myStack.Peek()}");
            myStack.Push(-5);
            Console.WriteLine($"My Stack contains: {myStack.Peek()}");
            myStack.Push(0);

            Console.WriteLine($"Top Value: {myStack.Peek()}");
            Console.WriteLine($"Removed: {myStack.Pop()}");
            Console.WriteLine($"Removed: {myStack.Pop()}");
            Console.WriteLine($"Top Value: {myStack.Peek()}");
        }
    }
}
