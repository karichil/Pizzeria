using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pizzeria.Models
{
    public class Pizza : Product
    {
        public enum Dough
        {
            Thin = 1,
            Thick =2
        }
    }
}