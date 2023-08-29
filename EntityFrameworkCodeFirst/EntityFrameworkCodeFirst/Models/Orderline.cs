using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst.Models
{
    public class Orderline
    {
        public int Id { get; set; }
        public int Quantity { get; set; } = 1;

        public int OrderId { get; set; }
        [JsonIgnore] // avoids infinite loop for reading order since we have two foreign keys 
        public virtual Order? Order { get; set; } = null;

        public int ItemId { get; set; }
        public virtual Item? Item { get; set; } = null;
    }
}
