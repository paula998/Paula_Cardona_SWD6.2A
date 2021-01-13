using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShoppingCart.Domain.Models
{
   public class Cart
    {
        [Key]
        public Guid CartId { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        
        public string UserEmail { get; set; }


    }
}
