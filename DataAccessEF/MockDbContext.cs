using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace DataAccessEF
{
    public class MockDbContext : DbContext
    {
        public MockDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Products
        {
            get;
            set;
        }
   
    }
}
