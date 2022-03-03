using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Mission9_Bookstore.Models;

namespace Mission9_Bookstore.Models
{
    public class Purchase
    {
        [Key]
        [BindNever]
        public int PurchaseId { get; set; }

        [BindNever]
        public ICollection<CartLineItem> Lines { get; set; }

        [Required(ErrorMessage ="Please enter the name:")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the address:")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }

        [Required(ErrorMessage = "Please enter the city:")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter the state:")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter the zip:")]
        public string Zip { get; set; }

        [Required(ErrorMessage = "Please enter the country:")]
        public string Country { get; set; }

    }
}
