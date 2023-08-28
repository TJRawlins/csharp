using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExamples
{
    // should be public to use in other classes and inherit from DbContext
    public class AppDbContect : DbContext
    {
        // let DbContext know you want access to the Customers and Orders table. Returns list
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }

        // constructor - only used in console app
        public AppDbContect() { }

        // pass options to base constructor - MUST HAVE ALWAYS
        public AppDbContect(DbContextOptions<AppDbContect> options) : base(options) { }

        // implement connection string - for web apps this goes in a different file
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connStr = "server=localhost\\sqlexpress;" +
                            "database=SalesDb;" +
                            "trusted_connection=true;" +
                            "trustServerCertificate=true;";

            optionsBuilder.UseSqlServer(connStr);
        }

    }
}
