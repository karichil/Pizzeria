using Microsoft.EntityFrameworkCore;
using Pizzeria.Models;
using Pizzeria.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizzeria
{
    public class PizzaContext : DbContext
    {
        DbSet<Address> Addresses { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<MainPizzeria> MainPizzerias { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<OrderProduct> OrderProducts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProduct>()
                 .HasKey(op => new { op.OrderID, op.ProductID });

            modelBuilder.Entity<MainPizzeria>()
                 .HasMany(p => p.Products);

             modelBuilder.Entity<MainPizzeria>()
                 .HasMany(u => u.Users);
        }
    }

}