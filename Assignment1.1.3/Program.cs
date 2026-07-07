// This portion of the code gets the user's input and prints out the
// quotient and remainder to the console

Console.Write("Enter the dividend: ");
double dividend = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the divisor: ");
double divisor = Convert.ToDouble(Console.ReadLine());

double quotient = (double)dividend / divisor;
double remainder = dividend % divisor;
Console.WriteLine("The quotient of " + dividend + " divided by " + divisor + " is "
+ quotient + " with a remainder of " + remainder + ".\n");