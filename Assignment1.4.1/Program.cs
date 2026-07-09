namespace Assignment1._4._1
{
    // Defining Structure
    public struct Point
    {
        // Data members
        public int xCoordinate;
        public int yCoordinate;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Point variables 
            Point p1 = new Point { xCoordinate = 4, yCoordinate = 5 };
            Point p2 = new Point { xCoordinate = 6, yCoordinate = 7 };

            if (p2.xCoordinate > p1.xCoordinate)
            {
                Console.WriteLine("P2 is to the right of P1.");
            } else if (p2.xCoordinate < p1.xCoordinate)
            {
                Console.WriteLine("P2 is to the left of P1.");
            } else
            {
                Console.WriteLine("P2 is in the same axis of P1.");
            }
        }
    }
}
