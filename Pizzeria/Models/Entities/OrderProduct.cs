using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizzeria.Models.Entities
{
    public class OrderProduct
    {
        public long OrdereId { get; set; }
        public virtual Order Order { get; set; }
        public long ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}