using System;
using System.Collections.Generic;

namespace EntityFrameworkDBFirst.Models;

public partial class Request
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public string Justification { get; set; } = null!;

    public string? RejectionReason { get; set; }

    public string DeliveryMode { get; set; } = null!;

    public string? Status { get; set; }

    public decimal? Total { get; set; }

    public int UserId { get; set; }

    public virtual ICollection<RequestLine> RequestLines { get; set; } = new List<RequestLine>();

    public virtual User User { get; set; } = null!;
}
