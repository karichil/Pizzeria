using System;
using System.Collections;
using System.Collections.Generic;
using WebGrease;

namespace Pizzeria.Models
{
    public class Order
    {
        public long Id { get; set; }
        public long ClientId { get; set; } 
        public virtual Client Client { get; set; }
        public DateTime DateOdOrder { get; set; } 
        public DateTime DeliveryDate { get; set; }
        public enum OrderState
        {
            Created = 0,
            InRealization = 1,
            InDelivery = 2,
            Completed = 3,
            Deleted = -1
        }
        public virtual ICollection<Product> Products { get; set; }
    }
}