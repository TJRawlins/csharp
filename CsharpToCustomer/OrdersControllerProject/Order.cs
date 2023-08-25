using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderController
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Id,2} | {CustomerId,2} | {Date} | {Description,-30}"; 
        }

        public static string SqlGetAll = "SELECT * FROM Orders ORDER BY Date;";
        public static string SqlGetById = "SELECT * FROM Orders WHERE Id = @Id;";

    }
}