using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiExample.Models
{
    public class Item
    {
        public int Id { get; set; }
        [StringLength(40)]
        public string Name { get; set; }
        [Column(TypeName = "decimal(7,2)")]
        public decimal Price { get; set; }

    }
}
