using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20204241_ITT209F2021_ESA {
    internal class Employee {
        public Employee() { }

        public int EmployeeID { get; }
        public int TRN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyContactPhone { get; set; }
        public string Password { get; set; }

    }
}
