// This portion of the code prints out my name, age and address to the console

Console.WriteLine("Please enter your name: ");
string name = Console.ReadLine();
Console.WriteLine("Please enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter your address: ");
string address = Console.ReadLine();

Console.WriteLine($"My name is {name}, {age} years old, " +
    $"and I this is my {address}");

