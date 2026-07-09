namespace Assignment1._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Welcome message
            Console.WriteLine("Welcome To Basic Area Formulas App\n");

            // Repeat of the calculator
            bool keepRunning = true;

            while (keepRunning)
            {
                // Print Menu
                FormulaMenu();

                // Calculate Area of a shape option
                int choice = CalculateAreaOption();

                // breaks the loop if the user chooses to exit
                if (choice == 4)
                {
                    Console.WriteLine("Thank you for using my Calculator");
                    keepRunning = false;
                } else
                {
                    CalculateAreaFormulas(choice);
                }
            }

        }
        // Formula Menu Template
        static void FormulaMenu()
        {
            string calculateAreaOf = "Calculate Area of";
            Console.WriteLine("Please select an area of a shape you want to calculate");
            Console.WriteLine($"1. {calculateAreaOf} Triangle");
            Console.WriteLine($"2. {calculateAreaOf} Square");
            Console.WriteLine($"3. {calculateAreaOf} Rectangle");
            Console.WriteLine($"4. To Exit"); 
            Console.Write("Enter your choice (1-4): ");

        }
        // Users Response
        static int CalculateAreaOption()
        {
            // The users response is saved as choice
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        // Formula options
        static void CalculateAreaFormulas(int choice)
        {
            switch (choice)
            {
                case 1:
                    AreaOfTriangle();
                    break;
                case 2:
                    AreaofSquare();
                    break;
                case 3:
                    AreaOfRectangle();
                    break;
                default:
                    // Invalid choice 
                    Console.WriteLine("\nPlease select a valid number.\n");
                    break;
            }
        }
        // Area of Triangle calculation
        static void AreaOfTriangle()
        {
            Console.Write("\nEnter the base of the triangle: ");
            double baseTriangle = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nEnter the height of the triangle: ");
            double heightTriangle = Convert.ToDouble(Console.ReadLine());
            double areaOfTriangle = (baseTriangle * heightTriangle) / 2;
            Console.WriteLine($"\nArea of the triangle is {areaOfTriangle}\n");
        }
        // Area of Square calculation
        static void AreaofSquare()
        {
            Console.Write("\nEnter the side of the square: ");
            double sideSquare = Convert.ToDouble(Console.ReadLine());
            double areaOfSquare = sideSquare * sideSquare;
            Console.WriteLine($"\nArea of the Square is {areaOfSquare}\n");

        }
        // Area of Rectangle calculation
        static void AreaOfRectangle()
        {
            Console.Write("\nEnter the length of the rectangle: ");
            double lengthRectangle = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nEnter the width of the rectangle: ");
            double widthRectangle = Convert.ToDouble(Console.ReadLine());
            double areaOfRectangle = lengthRectangle * widthRectangle;
            Console.WriteLine($"\nArea of the Rectangle is {areaOfRectangle}\n");
        }
    }
}
