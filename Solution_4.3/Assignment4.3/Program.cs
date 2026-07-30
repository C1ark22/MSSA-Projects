namespace Assignment4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input customer ID
            Console.Write("Enter Customer ID: ");
            int customerId = Convert.ToInt32(Console.ReadLine());

            // Customer Name
            Console.Write("Enter Customer Name: ");
            string customerName = Console.ReadLine() ?? "";

            Console.Write("Enter Unit Consumed: ");

            double usedUnit;
            while (!double.TryParse(Console.ReadLine(), out usedUnit) || usedUnit <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a number greater than 0.");
                Console.Write("Enter Unit Consumed: ");
            }

            var result = unitConsumed(usedUnit);

            double priceUnitCharge = result.priceUnitCharge;
            double amountCharges = result.amountCharges;
            double surcharge = result.surcharge;
            double totalCharge = result.totalCharge;

            Console.WriteLine($"Customer IDNO: {customerId}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Amount Charges @${priceUnitCharge:F2} per unit: {amountCharges:F2}");
            Console.WriteLine($"Surcharge Amount: {surcharge:F2}");
            Console.WriteLine($"Net Amount Paid by the Customer: {totalCharge:F2}");
        }

        static (double priceUnitCharge, double amountCharges, double surcharge, double totalCharge) unitConsumed(double usedUnit)
        {
            double priceUnitCharge = 0;
            double amountCharges = 0;
            double surcharge = 0;
            double totalCharge = 0;

            switch (usedUnit)
            {
                case >= 600:
                    priceUnitCharge = 2.00;
                    amountCharges = usedUnit * priceUnitCharge;
                    surcharge = amountCharges * 0.15;
                    totalCharge = amountCharges + surcharge;
                    break;
                case >= 400:
                    priceUnitCharge = 1.80;
                    amountCharges = usedUnit * priceUnitCharge;
                    surcharge = amountCharges * 0.15;
                    totalCharge = amountCharges + surcharge;
                    break;
                case >= 200:
                    priceUnitCharge = 1.50;
                    amountCharges = usedUnit * priceUnitCharge;
                    if (amountCharges >= 400)
                    {
                        surcharge = amountCharges * 0.15;
                        totalCharge = amountCharges + surcharge;
                    }
                    else
                    {
                        totalCharge = amountCharges;
                    }
                    break;
                case > 0:
                    priceUnitCharge = 1.20;
                    amountCharges = usedUnit * priceUnitCharge;
                    surcharge = amountCharges * 0.15;
                    totalCharge = amountCharges + surcharge;
                    break;
            }

            return (priceUnitCharge, amountCharges, surcharge, totalCharge);
        }

    }
}
