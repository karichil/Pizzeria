using System;

namespace Pizzeria.Models
{
    public class Employee:User
    {
        public long Id { get; set; }
        public DateTime DateoOfEmployment { get; set; }
    }
}