using Microsoft.EntityFrameworkCore;
using SShop.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SShop.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Specification> Specifications { get; set; }
    }
}
