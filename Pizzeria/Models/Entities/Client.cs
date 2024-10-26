using System.Collections.Generic;

namespace Pizzeria.Models
{
    public class Client : User
    {
        public virtual ICollection<Order> Orders { get; set; }
        public long AddressId { get; set; }
        public virtual Address Address { get; set; }
    }
}