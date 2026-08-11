using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6._1._1
{
    public class House
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
    }
}
