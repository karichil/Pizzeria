using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Pizzeria.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required(ErrorMessage ="Category name is required!")]
        public string CategoryName { get; set; }

        //Klucze obce i po³¹czenia
        public virtual ICollection<User> Users { get;}
        
    }
}