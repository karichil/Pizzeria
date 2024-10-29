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
        DbSet<Category> Categories { get; set; }
        DbSet<Role> Roles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<OrderProduct>()
                .HasKey(op => new { op.OrderID, op.ProductID });

            modelBuilder.Entity<Address>()
                .HasOne(u => u.User)
                .WithOne(a => a.Address)
                .HasForeignKey<User>(u => u.AddressID);

            modelBuilder.Entity<User>()
                .HasOne(a => a.Address)
                .WithOne(u => u.User)
                .HasForeignKey<Address>(a => a.UserID);


            modelBuilder.Entity<Category>()
                .HasMany(p => p.Products)
                .WithOne(c => c.Category);

            modelBuilder.Entity<MainPizzeria>()
                .HasMany(p => p.Products)
                .WithOne(mp => mp.MainPizzeria);

            modelBuilder.Entity<MainPizzeria>()
                .HasMany(u=>u.Users)
                .WithOne(mp => mp.MainPizzeria);

            modelBuilder.Entity<Order>()
                .HasOne(u => u.User)
                .WithMany(o => o.Orders);

            modelBuilder.Entity<User>()
                .HasOne(r => r.Role)
                .WithMany(u => u.Users);

        }
    }

}