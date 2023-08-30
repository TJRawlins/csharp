using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BootcampWebApi.Models;

namespace BootcampWebApi.Data
{
    public class BootcampDbContext : DbContext
    {
        public BootcampDbContext (DbContextOptions<BootcampDbContext> options)
            : base(options)
        {
        }

        public DbSet<Assessment> Assessments { get; set; } = default!;

        public DbSet<BootcampWebApi.Models.Score> Scores { get; set; } = default!;

        public DbSet<BootcampWebApi.Models.Student> Students { get; set; } = default!;
    }
}
