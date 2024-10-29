using Pizzeria.Models.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebGrease;

namespace Pizzeria.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [Required]
        public DateTime DateOfOrder { get; set; }

        [Required]
        public DateTime DeliveryDate { get; set; }

        public decimal TotalPrice { get; set; }

        public enum OrderState
        {
            Created = 0,
            InRealization = 1,
            InDelivery = 2,
            Completed = 3,
            Deleted = -1
        }

        //Klucze obce i połączenia
        public int UserID { get; set; }
        public virtual User User { get; set; }
        
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
        
    }
}