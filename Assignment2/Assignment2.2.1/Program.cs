using System.ComponentModel.DataAnnotations;

namespace Assignment2._2._1
{
    public class University
    {
        public string universityName = "San Francisco State University";
    }

    // College of Science and Engineering is the first child of University
    public class CollegeOfScienceAndEngineering : University
    {
        public string collegeOfScience = "College of Science and Engineering";
    }

    // Represents the Computer Science Department under
    // the College of Science and Engineering
    public class ComputerScienceDepartment : CollegeOfScienceAndEngineering
    {
        public string departmentName = "Computer Science Department";
    }
    // Represents the Science Department under
    // the College of Science and Engineering
    public class ScienceDepartment : CollegeOfScienceAndEngineering
    {
        public string departmentName = "Science Department";
    }

    // Represents the Computer Science degree program under
    // the Computer Science Department
    public class ComputerScienceDegree : ComputerScienceDepartment
    {
        public string degreeProgram = "Bachelor of Science in Computer Science";
    }
    // Represents the Science degree program under
    // the Science Department
    public class ScienceDegree : ScienceDepartment
    {
        public string degreeProgram = "Bachelor of Science in Biology";
    }


    // College of Business is the second child of University
    public class CollegeOfBusiness : University
    {
        public string collegeOfBusiness = "Lam Family College of Business";
    }
    public class BusinessDepartment : CollegeOfBusiness
    {
        public string departmentName = "Business Administration Department";
    }
    public class BusinessDegree : BusinessDepartment
    {
        public string degreeProgram = "Bachelor of Business Administration";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a stemCollege object
            ComputerScienceDegree stemCollege = new ComputerScienceDegree();
            ScienceDegree bioDegree = new ScienceDegree();

            // Display the value of the hierarchy
            Console.WriteLine($"{stemCollege.universityName}");
            Console.WriteLine($"└── {stemCollege.collegeOfScience}");
            Console.WriteLine($"│   └── {stemCollege.departmentName}");
            Console.WriteLine($"│   |   └── {stemCollege.degreeProgram}");
            Console.WriteLine($"│   └── {bioDegree.departmentName}");
            Console.WriteLine($"│       └── {bioDegree.degreeProgram}");

            BusinessDegree businessCollege = new BusinessDegree();

            Console.WriteLine($"└── {businessCollege.collegeOfBusiness}");
            Console.WriteLine($"    └── {businessCollege.departmentName}");
            Console.WriteLine($"        └── {businessCollege.degreeProgram}");


        }
    }
}
