using System.ComponentModel.DataAnnotations;

namespace Pizzeria.Models
{
    public class Address
    {
        [Key]
        public int AdressID { get; set; }

        [Required(ErrorMessage = "Type your city. ")]
        [StringLength(200, ErrorMessage = "Max Length is 201")]
        public string City { get; set; }

        [Required(ErrorMessage = "Type your street. ")]
        [StringLength(200, ErrorMessage = "Max Length is 200")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Type your appartment number. ")]
        [MaxLength(200, ErrorMessage = "Max Length is 200")]
        public int ApartmentNumber { get; set; }

        [Required(ErrorMessage = "Type your Postal code. ")]
        [StringLength(200, ErrorMessage = "Max Length is 200")]
        public string PostalCode { get; set; }

        //Klucze obce i połączenia
        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}