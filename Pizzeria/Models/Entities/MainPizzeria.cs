using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizzeria.Models
{
    public class MainPizzeria
    {
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}