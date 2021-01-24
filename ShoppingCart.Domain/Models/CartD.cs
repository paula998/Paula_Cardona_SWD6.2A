using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShoppingCart.Domain.Models
{
   public class CartD
    {
        [Key]
        public Guid CartId { get; set; }

        public Guid ProductId_FK { get; set; }

        public int Quantity { get; set; }

        public string UserEmail { get; set; }


    }
}
