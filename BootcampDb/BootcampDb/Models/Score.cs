using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampDb.Models
{
    public class Score
    {
        public int Id { get; set; }
        public int Points { get; set; }

        // FOREIGN KEYS
        public int StudentId { get; set;}
        public virtual Student? Student { get; set; } = null;

        public int AssessmentId { get; set; }
        public virtual Assessment? Assessment { get; set; } = null;

    }
}
