using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._4._1.Modules
{
    public abstract class Beverage
    {
        public string Name { get; set; }
        public string Size { get; set; }

        public Beverage() { }

        public Beverage(string name, string size)
        {
            Name = name;
            Size = size;
        }
    }
}
