using System.Globalization;
using System.Numerics;

namespace Assignment2._3._2
{
    public class UserDetails() 
    {
        public decimal billAmount {  get; set; }
        public decimal tipPercentage { get; set; }

        public void GetUserInput()
        {
            Console.Write("Please enter the total amount of the bill: ");
            billAmount = Convert.ToDecimal(Console.ReadLine());

            Console.Write("\nPlease enter the % of the tip: ");
            tipPercentage = Convert.ToDecimal(Console.ReadLine()) / 100;
        }

        public void DisplayDetails()
        {
            CultureInfo usCulture = new CultureInfo("en-US");

            Decimal tip = billAmount * tipPercentage;
            Decimal overallTotal = billAmount + tip;

            Console.WriteLine($"\nYour bill amount is {billAmount.ToString("C2", usCulture)} " +
                $"and your tip percentage is {tipPercentage.ToString("P0", usCulture)} " +
                $"tip amount is {tip.ToString("C2",usCulture)}");

            Console.WriteLine($"\nYour total bill is {overallTotal.ToString("C2", usCulture)}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            UserDetails userBill = new UserDetails();

            userBill.GetUserInput();

            userBill.DisplayDetails();
            
        }
    }
}
