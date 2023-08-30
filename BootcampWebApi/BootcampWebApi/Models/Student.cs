using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BootcampWebApi.Models;

public partial class Student
{
    public int Id { get; set; }
    [StringLength(30)]
    public string? Name { get; set; }
    [StringLength(30)]
    public string? Email { get; set; }
    [StringLength(30)]
    public string? Phone { get; set; }


}
