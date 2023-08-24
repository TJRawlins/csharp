using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerController
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public decimal Sales { get; set; }
        public bool Active { get; set; }

        // Display in a more readable format when debugging only
        public override string ToString()
        {
            //redefine what ToString() does
            return $"{Id,2:N0} | {Name, -20} | {City}, {State} | {Sales, 12:C} {Active}";
        }
    }


}
