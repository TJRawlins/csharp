using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BootcampWebApi.Models;

public partial class Assessment
{
    public int Id { get; set; }
    [StringLength(30)]
    public string? Topic { get; set; }

    public virtual ICollection<Score> Scores { get; set; } = new List<Score>();
}
