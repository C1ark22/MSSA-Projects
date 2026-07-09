namespace Assignment1._4._2
{
    class Student
    {
        // The attributes of the student
        private int studentID;
        private string studentFname;
        private string studentLname;
        private char studentGrade;

        // Public properties with getters and setters
        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public string StudentFname
        {
            get { return studentFname; }
            set { studentFname = value; }
        }

        public string StudentLname
        {
            get { return studentLname; }
            set { studentLname = value; }
        }

        public char StudentGrade
        {
            get { return studentGrade; }
            set { studentGrade = value; }
        }

        // Creates a Student object using the constructors to assign values
        public Student(int id, string firstname, string lastname, char grade)
        {
            studentID = id;
            studentFname = firstname;
            studentLname = lastname;
            studentGrade = grade;
        }

        // Console.WriteLine(studentInfo) works because C# automatically calls ToString().
        // Without overriding ToString(), it prints the class name "Student".
        // With overriding ToString(), it prints the student information below.
        public override string ToString()
        {
            return $"Student ID: {studentID}\n" +
                $"Student First Name: {studentFname}\n" +
                $"Student Last Name: {studentLname}\n" +
                $"Student Grade: {studentGrade}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates a Student object and initializes it with (ID, "Fname", "Lname", 'Grade')
            Student studentInfo = new Student(1234234, "Clark", "Batungbakal", 'A');

            // Getter
            Console.WriteLine("Hard coded grade that is getting from the object: " 
                + studentInfo.StudentGrade);

            // Setter
            studentInfo.StudentGrade = 'B';

            // Prints the Student Object using the overwritten ToString() method
            // if there wasn't ToString() method it would print "Student"
            Console.WriteLine(studentInfo);
        }
    }
}