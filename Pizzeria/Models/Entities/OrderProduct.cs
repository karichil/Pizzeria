using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizzeria.Models.Entities
{
    public class OrderProduct
    {
        //Klucze obce i połączenia
        public int OrderID { get; set; }
        public virtual Order Order { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}