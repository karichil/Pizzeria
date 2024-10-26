using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing.Imaging;
using System.Drawing;
using Pizzeria.Models.Entities;

namespace Pizzeria.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public enum Category
        {
            Pizza = 1,
            Addition = 2,
            Drink = 3
        }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool IsOnSale { get; set; }
        public Image SmallImage { get; set; }
        public Image BigImage { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get;}
    }
}