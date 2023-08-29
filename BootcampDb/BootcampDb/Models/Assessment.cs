using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampDb.Models
{
    public class Assessment
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string? Topic { get; set; } = string.Empty;

        public virtual ICollection<Score> Scores { get; set; }
    }
}
