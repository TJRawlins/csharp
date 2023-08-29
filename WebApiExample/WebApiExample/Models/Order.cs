using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiExample.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; } = DateTime.Now;
        [StringLength(80)]
        public string Description { get; set; } = string.Empty;
        [Column(TypeName = "decimal(11,2)")]
        public decimal Total { get; set; }
        [StringLength(30)]
        public string Status { get; set; } = "NEW";

        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; } = null;

        public virtual List<Orderline>? Orderlines { get; set; } = null;
    }
}
