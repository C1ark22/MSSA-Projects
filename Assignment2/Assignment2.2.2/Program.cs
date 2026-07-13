namespace Assignment2._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator Menu");

            bool keepRunning = true;

            while (keepRunning)
            {
                PrintMenu();

                int userChoice = Convert.ToInt32(Console.ReadLine());

                if (userChoice == 5)
                {
                    Console.WriteLine("Thank you for using my Calculator");
                    keepRunning = false;
                }
                else 
                {
                    switch (userChoice)
                    {
                        case 1:
                            Console.Write("Enter the first whole number: ");
                            int firstNumber = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter the second whole number: ");
                            int secondNumber = Convert.ToInt32(Console.ReadLine());

                            int twoNumberResult = Add(firstNumber, secondNumber);

                            Console.WriteLine($"Result: {twoNumberResult}\n");
                            break;
                        case 2:
                            Console.Write("Enter the first number: ");
                            decimal firstAddValue = Convert.ToDecimal(Console.ReadLine());

                            Console.Write("Enter the second number: ");
                            decimal secondAddValue = Convert.ToDecimal(Console.ReadLine());

                            Console.Write("Enter the third number: ");
                            decimal thirdAddValue = Convert.ToDecimal(Console.ReadLine());

                            decimal threeAddResult = Add(firstAddValue,secondAddValue,thirdAddValue);

                            Console.WriteLine($"Result: {threeAddResult}\n");
                            break;
                        case 3:
                            Console.Write("Enter the first number: ");
                            float firstMulitplyNumber = Convert.ToSingle(Console.ReadLine());

                            Console.Write("Enter the second number: ");
                            float secondMultiplyNumber = Convert.ToSingle(Console.ReadLine());

                            float twoMultiplyResult = Multiply(firstMulitplyNumber,secondMultiplyNumber);

                            Console.WriteLine($"Result: {twoMultiplyResult}\n");
                            break;
                        case 4:

                            Console.Write("Enter the first number: ");
                            float firstMultiplyValue = Convert.ToSingle(Console.ReadLine());

                            Console.Write("Enter the second number: ");
                            float secondMultiplyValue = Convert.ToSingle(Console.ReadLine());

                            Console.Write("Enter the third number: ");
                            float thirdMultiplyValue = Convert.ToSingle(Console.ReadLine());

                            float threeMultiplyResult = Multiply(firstMultiplyValue, secondMultiplyValue, thirdMultiplyValue);

                            Console.WriteLine($"Result: {threeMultiplyResult}\n");
                            break;
                        default:
                            Console.WriteLine("Please select a valid number.\n");
                            break;
                    }
                }
            }

        }
        // Menu template
        static void PrintMenu()
        {
            Console.WriteLine("Please select an operation:");
            Console.WriteLine("1. Add 2 numbers");
            Console.WriteLine("2. Add 3 numbers");
            Console.WriteLine("3. Multiply 2 numbers ");
            Console.WriteLine("4. Multiply 3 numbers");
            Console.WriteLine("5. To Exit\n");
            Console.Write("Enter your choice (1-5): ");
        }

        public static int Add(int firstNumber, int secondNumber) 
        {
            return firstNumber + secondNumber;
        }

        public static decimal Add(decimal firstAddValue, decimal secondAddValue, decimal thirdAddValue)
        {
            return firstAddValue + secondAddValue + thirdAddValue;
        }

        public static float Multiply (float firstNumber, float secondNumber) 
        { 
            return firstNumber * secondNumber; 
        }

        public static float Multiply(float firstMultiplyValue, float secondMutiplyValue, float thirdMultiplyValue)
        {
            return firstMultiplyValue * secondMutiplyValue * thirdMultiplyValue;
        }

    }
}
