using Archi.API.Data;
using Archi.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Archi.Test.data
{
    public class MockDbContext : ArchiDbContext
    {
        public MockDbContext(DbContextOptions options):base(options)
        {
        }

        public static MockDbContext GetDbContext(bool withData = true)
        {
            var options = new DbContextOptionsBuilder().UseInMemoryDatabase("dbtest").Options;
            var db = new MockDbContext(options);

            if (withData)
            {
                db.Customers.Add(new Customer { Active = true, Lastname = "Bob 1", Firstname = "Bob", Email = "rien" });
                db.Customers.Add(new Customer { Active = true, Lastname = "Bob 2", Firstname = "Bob", Email = "rien" });
                db.Customers.Add(new Customer { Active = true, Lastname = "Bob 3", Firstname = "Bob", Email = "rien" });
                db.SaveChanges();
            }
            return db;
        }
    }
}
