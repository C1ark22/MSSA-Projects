using System;
using System.Collections.Generic;
using System.Text;

namespace Solution_3_3.Models
{
    //public enum AdmissionMonth
    //{
    //    January = 1,
    //    February,
    //    March,
    //    April,
    //    May,
    //    June,
    //    July,
    //    August,
    //    September,
    //    October,
    //    November,
    //    December
    //}
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentAddress { get; set; }
        public string MonthOfAdmission { get; set; }
        public char Grade { get; set; }

        public Student() { }

        public Student(int studentID, string firstName, string lastName, string address, string monthOfAdmission, char grade)
        {
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
            StudentAddress = address;
            MonthOfAdmission = monthOfAdmission;
            Grade = grade;
        }

        public string GetStudentInformation()
        {
            return $"Student ID: {StudentID}, " +
                $"Name: {FirstName} {LastName}, " +
                $"Address: {StudentAddress}, " +
                $"Month of Admission: {MonthOfAdmission}, " +
                $"Grade: {Grade}";
        }
    }
}
