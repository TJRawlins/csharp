using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampDb.Models
{
    public class BootcampContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<Score> Scores { get; set; }

        public BootcampContext() { }

        public BootcampContext(DbContextOptions<BootcampContext> options) :base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connStr = "server=localhost\\sqlexpress;database=BootcampDb;trusted_connection=true;trustServerCertificate=true;";
            optionsBuilder.UseSqlServer(connStr);
        }

    }
}
