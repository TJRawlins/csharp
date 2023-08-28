using System;
using System.Collections.Generic;

namespace EntityFrameworkDBFirst.Models;

public partial class Product
{
    public int Id { get; set; }

    public string PartNbr { get; set; } = null!;

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public string Unit { get; set; } = null!;

    public string? PhotoPath { get; set; }

    public int VendorId { get; set; }

    public virtual ICollection<RequestLine> RequestLines { get; set; } = new List<RequestLine>();

    public virtual Vendor Vendor { get; set; } = null!;
}
