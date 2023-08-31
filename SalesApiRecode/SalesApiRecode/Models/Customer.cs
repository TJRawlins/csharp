using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesApiRecode.Models
{
    [Index("Code", IsUnique = true)]
    public class Customer
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string Code { get; set; } = string.Empty;
        [StringLength(30)]
        public string Name { get; set; } = string.Empty;
        [Column(TypeName = "decimal(11,2)")]
        public decimal Sales { get; set; }
        public bool Active { get; set; } = true;

    }
}
