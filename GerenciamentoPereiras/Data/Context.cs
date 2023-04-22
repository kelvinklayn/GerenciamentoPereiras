using GerenciamentoPereiras.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoPereiras.Data
{
    public class Context : DbContext
    {
        public Context() : base() { }

        public DbSet<Product> Products{get; set;}
        public DbSet<Order> Orders { get; set;}

        public DbSet<ProductOrder> ProductOrders { get; set;}

        public DbSet<OrdersGroup> OrdersGroups { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=PereirasDB;Trusted_Connection=True;TrustServerCertificate=true;");
        }

    }



}
