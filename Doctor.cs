using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20204241_ITT209F2021_ESA {
    internal class Doctor : Employee {
        public Doctor() { }

        public int DoctorID { get; }
        public string DoctorName { get; set; }
        public bool Available {
            get {
                return this.Available;
            } 
            set {
                Available = true;
            }
                }

    }
}
