namespace ChallengeLab2._4
{
    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public int GradeInPhysics { get; set; }
        public int GradeInChemistry { get; set; }
        public int GradeInComputerApplication { get; set; }

        public Student (int rollNumber, string name, int gradeInPhysics,
               int gradeInChemistry, int gradeInComputerApplication)
        {
            RollNumber = rollNumber;
            Name = name;
            GradeInPhysics = gradeInPhysics;
            GradeInChemistry = gradeInChemistry;
            GradeInComputerApplication = gradeInComputerApplication;
        }

        public int CalculateTotalMarks()
        {
            return GradeInPhysics + GradeInChemistry + GradeInComputerApplication;
        }

        public decimal CalculatePercentage()
        {
            int totalMarks = CalculateTotalMarks();
            return (decimal) totalMarks / 300 * 100;
        }

        public string DetermineDivision()
        {
            decimal percentage = CalculatePercentage();

            if (percentage >= 70)
            {
                return "First Division";
            }
            else if (percentage >= 60)
            {
                return "Upper Second Division";
            }
            else if (percentage >= 50)
            {
                return "Lower Second Division";
            }
            else if (percentage >= 36)
            {
                return "Third Division";
            }
            else
            {
                return "Fail";
            }
        }

        public void DisplayResults()
        {

            Console.WriteLine($"Roll No: {RollNumber}");
            Console.WriteLine($"Name of Student: {Name}");
            Console.WriteLine($"Marks in Physics: {GradeInPhysics}");
            Console.WriteLine($"Marks in Chemistry: {GradeInChemistry}");
            Console.WriteLine($"Marks in Computer Application: {GradeInComputerApplication}");

            int totalMarks = CalculateTotalMarks();

            Console.WriteLine($"Total Marks: {totalMarks}");

            decimal percentage = CalculatePercentage();

            Console.WriteLine($"Percentage: {percentage:F2}");

            string division = DetermineDivision();

            Console.WriteLine($"Division: {division}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // student input their roll number
            Console.Write("Input the Roll Number of the student: ");
            int rollNumber = Convert.ToInt32(Console.ReadLine());

            // student enter their name
            Console.Write("Input the Name of the student: ");
            string name = Console.ReadLine();

            // input marks for 3 subjects (__,__,__)
            Console.Write("Input the marks of Physics, Chemistry, and Computer Application: ");
            string input = Console.ReadLine();

            string[] parts = input.Split(' ',StringSplitOptions.RemoveEmptyEntries);

            int gradeInPhysics = Convert.ToInt32(parts[0]);
            int gradeInChemistry = Convert.ToInt32(parts[1]);
            int gradeInComputerApplication = Convert.ToInt32(parts[2]);

            Student student = new Student
                (rollNumber, name, gradeInPhysics,
                gradeInChemistry, gradeInComputerApplication);

            student.DisplayResults();
            
        }
    }
}
