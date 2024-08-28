using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module02Exercise01.Model
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullNames => $"{FirstName} {LastName}";
        public string Position { get; set; }
        public string Dpt { get; set; }
        public int IsActive { get; set; }
    }
}

