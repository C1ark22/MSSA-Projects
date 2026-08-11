using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6._1._2
{
    public class House : IEquatable<House>
    {
        public int HouseNumber { get; set; }
        public string Address { get; set; }
        public string HouseType { get; set; }

        public House(int houseNumber, string address, string houseType)
        {
            HouseNumber = houseNumber;
            Address = address;
            HouseType = houseType;
        }

        // Defines when two House objects are equal based on their HouseNumber
        public bool Equals(House other)
        {
            // Check if the other object is null
            if (other == null)
                return false;
            // Compare the HouseNumber property for equality
            return this.HouseNumber == other.HouseNumber;
        }

        // Checks if the object is a House and then calls the Equals method
        public override bool Equals(object obj)
        {
            return base.Equals(obj as House);
        }

        // Uses the houseNumber to generate a hash code so equal houses have the same hash code
        public override int GetHashCode()
        {
            return HouseNumber.GetHashCode();
        }

    }
}
