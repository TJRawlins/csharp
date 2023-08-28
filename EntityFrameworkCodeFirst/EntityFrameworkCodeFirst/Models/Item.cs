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
    [Index("UPC", IsUnique = true)]
    public class Item
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string UPC { get; set; } = string.Empty;
        [StringLength(30)]
        public string Name { get; set; } = string.Empty;
        [Column(TypeName = "decimal(9,2)")]
        public decimal Price { get; set; } = 0;
        public bool Active { get; set; } = true;
    }
}
