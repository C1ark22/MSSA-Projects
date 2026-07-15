namespace Assignment2._4._3
{
    public class Coordinates
    {
        public int XValue {  get; set; }
        public int YValue { get; set; }

        public Coordinates(int xValue, int yValue) 
        {
            XValue = xValue;
            YValue = yValue;
        }
        public void DetermineQuadrants()
        {
            if (XValue > 0 && YValue > 0)
            {
                Console.WriteLine($"The coordinate point ({XValue},{YValue}) lies in the First Quadrant.");
            } else if (XValue < 0 && YValue > 0)
            {
                Console.WriteLine($"The coordinate point ({XValue},{YValue}) lies in the Second Quadrant.");
            } else if (XValue < 0 && YValue < 0)
            {
                Console.WriteLine($"The coordinate point ({XValue},{YValue}) lies in the Third Quadrant.");
            } else if (XValue > 0 || YValue < 0)
            {
                Console.WriteLine($"The coordinate point ({XValue},{YValue}) lies in the Fourth Quadrant.");
            } 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input value for X coordinate: ");
            int xValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input value for Y coordinate: ");
            int yValue = Convert.ToInt32(Console.ReadLine());

            Coordinates coordinates = new Coordinates(xValue,yValue);

            coordinates.DetermineQuadrants();

        }
    }
}
