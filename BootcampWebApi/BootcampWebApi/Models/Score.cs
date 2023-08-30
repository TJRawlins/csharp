using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BootcampWebApi.Models;

public partial class Score
{
    public int Id { get; set; }

    public int Points { get; set; }

    public int StudentId { get; set; }

    public int AssessmentId { get; set; }
    //[JsonIgnore]
    public virtual Student? Student { get; set; } = null;
    [JsonIgnore]
    public virtual Assessment? Assessment { get; set; }
}
