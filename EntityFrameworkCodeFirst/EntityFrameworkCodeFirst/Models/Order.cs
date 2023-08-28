using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        [StringLength(80)]
        public string Description { get; set; } = string.Empty;
        [StringLength(30)]
        public string Status { get; set; } = "NEW";
        [Column(TypeName = "decimal(11,2)")]
        public decimal Total { get; set; } = 0;

        // foreign key
        public int CustomerId { get; set; }
        // virtual means property is not in the database Order table. Need this for CustomerId foreign keys
        // must have a virtual instance of the Customer table to match the foreign key to the primary key
        public virtual Customer? Customer { get; set; } = null;


    }
}
