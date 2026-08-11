namespace Assignment_6._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House(123, "Microsoft Cir", "Residential");
            House house2 = new House(456, "Microsoft Cir", "Ranch");
            House house3 = new House(789, "Microsoft Cir", "Colonial");

            BuiltInClass(house1, house2, house3);
        }
        static void BuiltInClass(House house1, House house2, House house3)
        {
            LinkedList<House> houseList = new LinkedList<House>();
            houseList.AddLast(house1);
            houseList.AddLast(house2);
            houseList.AddLast(house3);

            Console.Write("Enter the house number to search: ");
            int searchHouseNumber = Convert.ToInt32(Console.ReadLine());

            // temp object to hold the house to find
            // if there is no temp object, the Find method will not work because its
            // looking for that object in the list, not just the house number
            // the temp object is created with the house number to search for, 
            // and empty strings for the other properties, since they are not needed for the search
            House houseToFind = new House(searchHouseNumber, string.Empty, string.Empty);

            // use the Find method to search for the house in the linked list
            LinkedListNode<House> foundNode = houseList.Find(houseToFind);

            if (foundNode != null)
            {
                House foundHouse = foundNode.Value;
                Console.WriteLine("House found:");
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
