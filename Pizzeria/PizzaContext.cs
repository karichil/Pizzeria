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
            
        }
    }

}