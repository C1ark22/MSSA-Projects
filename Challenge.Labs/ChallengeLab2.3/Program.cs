namespace ChallengeLab2._3
{
    public class Triangle
    {
        public int Number { get; set; }
        public int Width { get; set; } 

        public Triangle(int number, int width)
        {
            Number = number;
            Width = width;
        }

        public void Pattern()
        {
            for (int i = Width; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write($"{Number}");
                }
                Console.WriteLine();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the desired width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Triangle triangle = new Triangle(number,width);

            triangle.Pattern();
        }
    }
}
