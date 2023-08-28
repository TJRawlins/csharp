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
    [Index("Code", IsUnique = true)] // CLASS ATTRIBUTE - set Code to be a unique value
    public class Customer
    {
        
        [Key] // ATTRIBUTE - Primary Key
        public int Id { get; set; }
        [StringLength(30)]
        public string Code { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [Column(TypeName = "decimal(11,2)")]
        public decimal Sales { get; set; }
        public bool Active { get; set; } = true;

    }
}
