using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsProject
{
    internal class Student
    {
        // PROPERTIES
        public static int CohortNumber { get; set; } = 41; // static indicates this is a shared property amongst all the instances. If one instance changes it, it changes for all instances.
        public static int NextId { get; set; } = 1; // next id gets assigned to id once it gets incremented from previous instance. See student constructor below
        public int Id { get; set; } // value from next id gets assigned here in student constructor
        public string Name { get; set; }
        public string State { get; set; }

        // METHODS
        public static void Print(string message) // static method - no instances will use this method. Called by the Student class and not an instance of the class
        {
            Console.WriteLine(message);
        }
        public void ChangeName (string newName) {
            Name = newName;
        }
        // Can use same method name. The uniqueness will be the parameters
        public void ChangeName(string fName, string lName) {
            Name = fName + " " + lName;
        }

        public Student(string Name) : this(Name, "OH") { 
            
        }

        // CONSTRUCTOR - Initailize with defaults when creating instance of class
        // If you don't create one, VS will add one behind the scenes so you can still insttantiate an instance
        public Student(string Name = "New Student", string State = "OH")
        {
            this.Id = NextId++; // assign unique ID for each student that increments with each instance
            this.Name = Name;
            this.State = State;
        }
    }
}

