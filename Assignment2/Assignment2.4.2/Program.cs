namespace Assignment2._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            Console.Write("Input the first number: ");
            numbers[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number: ");
            numbers[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the third number: ");
            numbers[2] = Convert.ToInt32(Console.ReadLine());

            int greatestNumber = numbers[0];
            int greatestIndex = 0;

            // index compares second and third numbers
            for(int index = 1; index < numbers.Length; index++)
            {
                if (numbers[index] > greatestNumber)
                {
                    greatestNumber = numbers[index];
                    greatestIndex = index;
                }
            }
            
            string positionLabel = "";

            // greatest index is the element of the array
            switch (greatestIndex)
            {
                case 0:
                    positionLabel = "1st";
                    break;
                case 1:
                    positionLabel = "2nd";
                    break;
                case 2:
                    positionLabel = "3rd";
                    break;
            }

            Console.WriteLine($"The {positionLabel} number is the greatest among three.");
        }
    }
}
