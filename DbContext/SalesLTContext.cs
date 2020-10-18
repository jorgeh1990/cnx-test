using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CNX.TEST{

    public class SalesLTContext : DbContext
    {
         public SalesLTContext(DbContextOptions<SalesLTContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("SalesLT");
        }

         public DbSet<Product> Products { get; set; }
    }

}