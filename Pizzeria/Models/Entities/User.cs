using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pizzeria.Models
{
    public class User
    {
       [Key]
       public int UserID { get; set; }

       [Required(ErrorMessage = "Type your username. ")]
       [StringLength(200, ErrorMessage = "Max Length is 200")]
       public string UserName { get; set; }

       [Required(ErrorMessage = "Type your surname. ")]
       [StringLength(200, ErrorMessage = "Max Length is 200")]
       public string Surname { get; set; }

       [Required(ErrorMessage = "Type your email. ")]
       [StringLength(200, ErrorMessage = "Max Length is 200")]
       [EmailAddress]
       public string Email { get; set; }

       [Required]
       public string Password { get; set; }

       [Required]
       public DateTime Birthday_Date { get; set; }

       //Klucze obce i połączenia
       public int AddressID { get; set; }
       public virtual Address Address {  get; set; } 
       public int RoleID { get; set; }
       public virtual Role Role { get; set; } 
       public virtual ICollection <Order> Orders { get; set; }
       public int MainPIzzeriaID { get; set; } 
       public virtual MainPizzeria MainPizzeria { get; set; }
    }
}