using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExamples
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public int CustomerId { get; set; }

        public override string ToString()
        {
            return $"{Id} | {Date} | {Description} | {CustomerId} ";
        }
    }
}
