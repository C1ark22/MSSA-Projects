namespace Assignment2._2._3
{
    // Abstract parent class
    public abstract class Shape
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; } 

        // Every child class must provide its own area calculation
        public abstract double CalculateArea();
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Square : Shape 
    {
        public double Side { get; set; }

        public override double CalculateArea()
        {
            return Side * Side;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Calculator to Calculate Area.");

            // Menu
            Console.WriteLine("Please enter an ID: ");
            int shapeID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a name: ");
            string shapeName = Console.ReadLine();

            Console.WriteLine("Please enter a color: ");
            string shapeColor = Console.ReadLine();
            // add properties like id, name and color

            // add method calculate
            Console.WriteLine("Please select from below what you would like to calculate");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Square");
            Console.Write("Enter your choice 1 or 2: ");

            int areaToCalculate = Convert.ToInt32(Console.ReadLine());

            switch (areaToCalculate)
            {
                case 1:
                    // 
                    Circle circle = new Circle();

                    circle.Id = shapeID;
                    circle.Name = shapeName;
                    circle.Color = shapeColor;

                    Console.WriteLine("Please enter the radius:");
                    circle.Radius = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\n Shape Information");
                    Console.WriteLine($"ID: {circle.Id}");
                    Console.WriteLine($"Name: {circle.Name}");
                    Console.WriteLine($"Color: {circle.Color}");
                    Console.WriteLine($"Radius: {circle.Radius}");
                    Console.WriteLine($"Area: {circle.CalculateArea()}");

                    break;
                case 2:
                    //
                    Square square = new Square();

                    square.Id = shapeID;
                    square.Name = shapeName;
                    square.Color = shapeColor;

                    Console.Write("Enter the square side: ");
                    square.Side =
                        Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("\nShape Information");
                    Console.WriteLine($"ID: {square.Id}");
                    Console.WriteLine($"Name: {square.Name}");
                    Console.WriteLine($"Color: {square.Color}");
                    Console.WriteLine($"Side: {square.Side}");
                    Console.WriteLine($"Area: {square.CalculateArea()}");
                    break;
            } 

        }
    }
}
