//Write a program to create a list of employees.
//Consider a hard coded list. Display all employees
//who have salary more than $5000 and age < 30.

using System;
using System.Linq;

namespace Asssignment_10._2._2
{
    public class Employees
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employees> employee = new List<Employees>()
            {
                new Employees { Name = "John", Age = 25, Salary = 6000 },
                new Employees { Name = "Jane", Age = 28, Salary = 4500 },
                new Employees { Name = "Mike", Age = 32, Salary = 7000 },
                new Employees { Name = "Emily", Age = 29, Salary = 5500 },
                new Employees { Name = "David", Age = 27, Salary = 4000 }
            };

            var filteredEmployees = from empl in employee
                                    where empl.Salary > 5000 && empl.Age < 30
                                    select empl;

            Console.WriteLine("Employees with salary > $5000 and age < 30:");
            foreach (var emp in filteredEmployees)
            {
                Console.WriteLine($"Name: {emp.Name}, Age: {emp.Age}, Salary: {emp.Salary}");
            }
        }
    }
}
