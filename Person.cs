using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public abstract class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public int CellNumber { get; set; }

        public abstract void DisplayInfo();


    }
}
