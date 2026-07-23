using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._3._1.Models
{
    public enum AdmissionMonth
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    public abstract class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address StudentAddress { get; set; }
        public AdmissionMonth MonthOfAdmission { get; set; }
        public char Grade { get; set; }
    

    public Student(int studentID, string firstName, string lastName, Address address, AdmissionMonth monthOfAdmission, char grade)
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
