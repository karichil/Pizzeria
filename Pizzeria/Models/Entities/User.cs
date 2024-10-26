using System;

namespace Pizzeria.Models
{
    public class User
    {
       public long Id { get; set; }
       public string Name { get; set; }
       public string Surname { get; set; }
       public string Email { get; set; }
       //public string Login {  get; set; }
       public string Password { get; set; }
       public DateTime Birthday_Date { get; set; }
        public enum Role
        {
            Client = 1,
            Employee = 2,
            Admin = 3
        }
    }
}