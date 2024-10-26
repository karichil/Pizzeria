using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizzeria.Models
{
    public class Drink : Product
    {
        public int Id { get; set; } 
        public decimal Volume { get; set; }
    }
}