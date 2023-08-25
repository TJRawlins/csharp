using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersController
{
    public class Orders
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateOnly Date { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Id} | {CustomerId} | {Date} | {Description}"; 
        }
    }
}