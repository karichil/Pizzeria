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
        DbSet<Addition> Additions { get; set; }
        DbSet<Address> Addresses { get; set; }
        DbSet<Client> Clients { get; set; }
        DbSet<Drink> Drinks { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Pizza> Pizzas { get; set; }
        DbSet<MainPizzeria> MainPizzerias { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<OrderProduct> OrderProducts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProduct>()
                 .HasKey(op => new { op.OrdereId, op.ProductId });

            modelBuilder.Entity<MainPizzeria>()
                 .HasMany(p => p.Products);

             modelBuilder.Entity<MainPizzeria>()
                 .HasMany(u => u.Users);

            modelBuilder.Entity<Client>()
                .HasMany(a => a.Orders)
                .WithOne(c => c.Client);

            modelBuilder.Entity<Order>()
                .HasOne(c => c.Client)
                .WithMany(o => o.Orders);

            modelBuilder.Entity<Pizza>()
                .HasBaseType<Product>();

            modelBuilder.Entity<Addition>()
                .HasBaseType<Product>();

            modelBuilder.Entity<Drink>()
                .HasBaseType<Product>();

        }
    }

}