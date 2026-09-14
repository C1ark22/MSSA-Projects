using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Assignment_11._1
{
    public class Books
    {
        [Key]
        public long ISBN { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
    }
}
