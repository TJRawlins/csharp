using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebApiExample.Models
{
    public class Orderline
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string Product { get; set; } = string.Empty;
        [StringLength(80)]
        public string Description { get; set; } = string.Empty;
        public int Quantity { get; set; } = 1;
        [Column(TypeName = "decimal(11,2)")]
        public decimal Price { get; set; }

        public int OrderId { get; set; }
        public virtual Order? Order { get; set; }
    }
}
