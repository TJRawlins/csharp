using System;
using System.Collections.Generic;

namespace EntityFrameworkDBFirst.Models;

public partial class RequestLine
{
    public int Id { get; set; }

    public int RequestId { get; set; }

    public int ProductId { get; set; }

    public int? Quantity { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual Request Request { get; set; } = null!;
}
