using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing.Imaging;
using System.Drawing;
using Pizzeria.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace Pizzeria.Models
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }

        [Required(ErrorMessage = "Type your rolename. ")]
        [StringLength(200, ErrorMessage = "Max Length is 200")]
        public string RoleName { get; set; }

        //Klucze obce i po³¹czenia
        public virtual ICollection<User> Users { get; set; }
    }
}