using System;
using System.Collections.Generic;

namespace Assignment_4._1._1.Models
{
    public class Person
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName => $"{FirstName} {LastName}".Trim();
        public string MobileNumber { get; set; } = string.Empty;
        public string WorkPhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

        public Person() { }

        public Person(string firstName, string lastName, string mobileNumber, string workPhoneNumber, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            MobileNumber = mobileNumber;
            WorkPhoneNumber = workPhoneNumber;
            Address = address;
        }
    }
}
