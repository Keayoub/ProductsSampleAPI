using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductsSampleAPI.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsSampleAPI.Models
{
    public class CommerceDB : DbContext
    {
        public DbSet<Product> Products { get; set; }
        
        public DbSet<Customer> Customer { get; set; }

        public CommerceDB(DbContextOptions<CommerceDB> options)
              : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        
    }
}
