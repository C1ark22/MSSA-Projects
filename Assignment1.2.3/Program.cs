namespace Assignment1._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator App!\n");

            bool keepRunning = true;

            while (keepRunning)
            {
                // prints the Menu
                PrintMenu();

                // saves the users input in choice
                int choice = SelectedOperation();

                // breaks the loop if the user chooses to exit
                if (choice == 6)
                {
                    Console.WriteLine("Thank you for using my Calculator");
                    keepRunning = false;
                } 
                else
                {
                    RunVersion(choice);
                }
            }
        }
        // Menu template
        static void PrintMenu() 
        {
            Console.WriteLine("Please select an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Continue using the calculator");
            Console.WriteLine("6. To Exit\n");
            Console.Write("Enter your choice (1-6): ");
        }
        // Users choice
        static int SelectedOperation() 
        {
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
        // Runs the version what the users pick
        static void RunVersion(int choice) 
        {
            switch (choice)
            {
                case 1:
                    // Addition
                    RunVersAdd();
                    break;
                case 2:
                    // Subtraction
                    RunVersSub();
                    break;
                case 3:
                    // Multiplication
                    RunVersMult();
                    break;
                case 4:
                    // Division
                    RunVersDiv();
                    break;
                case 5:
                    // Continuing using the calculator
                    Console.WriteLine("Continuing using the calculator.\n");
                    break;
                default:
                    // Invalid choice 
                    Console.WriteLine("Please select a valid number.\n");
                    break;
            }
        }
        // Addition method
        static void RunVersAdd()
        {
            Console.Write("\nPlease input the first number you want to add: ");
            double addNum1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please input the second number you want to add: ");
            double addNum2 = Convert.ToDouble(Console.ReadLine());

            double sum = addNum1 + addNum2;
            Console.WriteLine($"{addNum1} plus {addNum2} equals {sum}\n");
        }
        // Subtraction method
        static void RunVersSub()
        {
            Console.Write("\nPlease input the first number you want to subtract: ");
            double subNum1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please input the second number you want to subtract: ");
            double subNum2 = Convert.ToDouble(Console.ReadLine());

            double difference = subNum1 - subNum2;

            Console.WriteLine($"{subNum1} minus {subNum2} equals {difference}\n");
        }
        // Multiplication method
        static void RunVersMult()
        {
            Console.WriteLine("\nPlease input the first number you want to multiply: ");
            double mulNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input the second number you want to multiply: ");
            double mulNum2 = Convert.ToDouble(Console.ReadLine());

            double product = mulNum1 * mulNum2;

            Console.WriteLine($"{mulNum1} times {mulNum2} equals {product}\n");
        }
        // Division method
        static void RunVersDiv()
        {
            Console.WriteLine("\nPlease input the dividend: ");
            double dividend = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please input the divisor: ");
            double divisor = Convert.ToDouble(Console.ReadLine());

            double quotient = dividend / divisor;
            double remainder = dividend % divisor;

            Console.WriteLine($"{dividend} divided by {divisor} equals {quotient}" +
                "with a remainder {remainder}\n");
        }
    }
}
