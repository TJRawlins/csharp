using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irrigation
{
    public class AppDbContext : DbContext
    {
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Zone> Zones { get; set; }

        public AppDbContext() {}

        public AppDbContext(DbContextOptions<AppDbContext> options) : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connStr = "server=localhost\\sqlexpress;" +
                            "database=PlantsDB;" +
                            "trusted_connection=true;" +
                            "trustServerCertificate=true;";
            optionsBuilder.UseSqlServer(connStr);
        }
    }
}
