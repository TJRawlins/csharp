using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampDb.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [StringLength(30)]
        public string? Name { get; set; } = string.Empty;
        [StringLength(30)]
        public string? Email { get; set; } = string.Empty;
        [StringLength(30)]
        public string? Phone { get; set; } = string.Empty;
    }
}
