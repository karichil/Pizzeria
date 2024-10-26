﻿namespace Pizzeria.Models
{
    public class Address
    {
        public long Id { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public int ApartmentNumber { get; set; }
    }
}