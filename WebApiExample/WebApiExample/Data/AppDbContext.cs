using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiExample.Models;

namespace WebApiExample.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // default adds the default value into the column instead of null
        public DbSet<Customer> Customers { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<Orderline> Orderlines { get; set; } = default!;
        public DbSet<Item> Items { get; set; } = default!;
        public DbSet<Employee> Employees { get; set; } = default!;
    }
}
