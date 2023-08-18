using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    internal class Instructor
    {
        public string Name { get; set; }
        public string State { get; set; }

        public Instructor(string Name = "New Instructor", string State = "OH") {
            this.Name = Name;
            this.State = State;
        } 

        // Constructor that allows instantiation without parameters
        public Instructor() { }
    }
}
