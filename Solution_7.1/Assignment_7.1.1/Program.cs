//You are a student who has recently taken an exam with your classmates.
//However, the professor has not yet provided the students with a sorted
//list of exam scores. To make things easier, you write a program to sort
//exam scores in ascending order using the selection sort algorithm.
//This way, you can obtain the sorted list of scores and see how you
//performed compared to your classmates. Also, you choose selection sort
//since that is an easy way of implementation.

namespace Assignment_7._1._1
{
    class Student
    {
        public string Name { get; set; }
        public int Grades { get; set; }

        public Student(string name, int grades)
        {
            Name = name;
            Grades = grades;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>() 
            {
                new Student("Clark", 87),
                new Student("John", 95),
                new Student("Sarah", 90),
                new Student("Bob", 79),
                new Student("Anna", 65),
            };

            SelectionSort(students);

            foreach(Student student in students)
            {
                Console.WriteLine($"{student.Name}: {student.Grades} ");
            }
        }
        static void SelectionSort(List<Student> students)
        {
            for (int i = 0; i < students.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < students.Count; j++)
                {
                    if (students[j].Grades < students[min].Grades)
                    {
                        min = j;
                    }
                }
                Student temp = students[i];
                students[i] = students[min];
                students[min] = temp;
            }
        }
    }
}
