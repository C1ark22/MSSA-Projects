using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_3._4._1.Modules
{
    public class Coffee : Beverage
    {
        public string RoastLevel { get; set; }
        public bool IsDecaf { get; set; }
        public Coffee(string name, string size, string roastLevel, bool isDecaf) : base(name, size)
        {
            RoastLevel = roastLevel;
            IsDecaf = isDecaf;
        }

        public Coffee() { }

    }
}
