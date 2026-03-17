using Microsoft.EntityFrameworkCore;
using Magazine.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Magazine.WebApi.Data
{
    public class DbInformation : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbInformation(DbContextOptions<DbInformation> options) : base(options) { Database.EnsureCreated(); }
    }
}
