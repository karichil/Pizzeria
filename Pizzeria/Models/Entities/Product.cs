using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing.Imaging;
using System.Drawing;
using Pizzeria.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace Pizzeria.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Product name is required!")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Price is required!")]
        [Range(0, 1000, ErrorMessage = "Incorrect amount!")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Description is required!")]
        [MaxLength(500, ErrorMessage = "Max lenght is 500!")]
        public string Description { get; set; }
        public bool IsOnSale { get; set; }
        public Image SmallImage { get; set; }
        public Image BigImage { get; set; }

        //Klucze obce i połączenia
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public int MianPizzeriaID { get; set; }
        public virtual MainPizzeria MainPizzeria { get; set; }
    }
}