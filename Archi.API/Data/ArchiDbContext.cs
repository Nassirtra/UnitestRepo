using Archi.API.Models;
using Archi.Library.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Archi.API.Data
{
    public class ArchiDbContext: BaseDbContext
    {
        public ArchiDbContext(DbContextOptions options):base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
    }
}
