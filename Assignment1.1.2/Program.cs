// This portion of the code gets the user's input and prints out the sum to the console

Console.Write("Enter the first number: ");
double num1 = Convert.To(Console.ReadLine());

Console.Write("Enter the second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

double sum = num1 + num2;
Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum + ".\n");