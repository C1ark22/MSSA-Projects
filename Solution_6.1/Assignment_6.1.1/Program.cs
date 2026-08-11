namespace Assignment_6._1._1
{
    class Node
    {
        public House Data;
        public Node Next;
        public Node(House data)
        {
            Data = data;
            Next = null;
        }
    }
    class SinglyLinkedList
    {
        private Node head;
        public void Add(House house)
        {
            Node newNode = new Node(house);

            // if the list is empty
            if (head == null)
            {
                head = newNode;
                return;
            }
            
            // start at the beginning
            Node current = head;
                
            // move until we reach the last node
            while (current.Next != null)
            {
                current = current.Next;
            }
                
            // connects the last node to the new node
            current.Next = newNode;
        }
        public House SearchByHouseNumber(int houseNumber)
        {
            // start at the beginning
            Node current = head;

            // move through the list until we reach the end
            while (current != null)
            {
                // check if the current node's data matches the search criteria
                if (current.Data.HouseNumber == houseNumber)
                {
                    return current.Data;
                }
                current = current.Next;
            }
            return null; // House not found
        }

    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            // implement a single linked list with each node representing a house.
            // you may add data in it like house number, brief addressm type of house
            // each house will be linked to the next
            // the user should be able to search a house by house number and
            // display the details of the house if found
            House house1 = new House(123, "Microsoft Cir", "Residential");
            House house2 = new House(456, "Microsoft Cir", "Ranch");
            House house3 = new House(789, "Microsoft Cir", "Colonial");

            CustomClass(house1, house2, house3);

        }
        static void CustomClass(House house1, House house2, House house3)
        {
            // This method is intentionally left empty to demonstrate a non-built-in method.
            // You can implement any custom logic here as needed.

            SinglyLinkedList houseList = new SinglyLinkedList();

            houseList.Add(house1);
            houseList.Add(house2);
            houseList.Add(house3);

            Console.Write("Enter the house number to search:");
            int houseNumber = Convert.ToInt32(Console.ReadLine());

            House foundHouse = houseList.SearchByHouseNumber(houseNumber);

            if (foundHouse != null)
            {
                Console.WriteLine("House found");
                Console.WriteLine($"House Number: {foundHouse.HouseNumber}");
                Console.WriteLine($"Address: {foundHouse.Address}");
                Console.WriteLine($"Type: {foundHouse.HouseType}");
            }
            else
            {
                Console.WriteLine("House not found.");
            }

        }
    }
}
