namespace Assignment_3._2._3
{
    public class Circle
    {
        public double Radius { get; set; }

        public Circle (double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        // overloading operator +
        public static double operator + (Circle firstCircle, Circle secondCircle)
        {
            return firstCircle.CalculateArea() + secondCircle.CalculateArea();
        }
        // overloading operator -
        public static double operator - (Circle firstCircle, Circle secondCircle)
        {
            return firstCircle.CalculateArea() - secondCircle.CalculateArea();
        }

    } 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Circle 1 radius: ");
            double radius1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Circle 2 radius: ");
            double radius2 = Convert.ToDouble(Console.ReadLine());

            // created objects for first and second object
            Circle firstCircle = new Circle(radius1);
            Circle secondCircle =  new Circle(radius2);

            Console.WriteLine($"The area of the first circle is {firstCircle.CalculateArea():F2}");
            Console.WriteLine($"The area of the second circle is {secondCircle.CalculateArea():F2}");

            double addedAreas = firstCircle + secondCircle;
            double areaDifference = firstCircle - secondCircle;

            Console.WriteLine($"Sum of the both areas: {addedAreas:F2}");
            Console.WriteLine($"Difference of the both areas: {areaDifference:F2}");
        }
    }
    
}
