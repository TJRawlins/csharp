using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesApiRecode.Models;

namespace SalesApiRecode.Data
{
    public class SalesApiRecodeContext : DbContext
    {
        public SalesApiRecodeContext (DbContextOptions<SalesApiRecodeContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; } = default!;
        public DbSet<Employee> Employees { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<Orderline> Orderlines { get; set; } = default!;
        public DbSet<Item> Items { get; set; } = default!;

    }
}
