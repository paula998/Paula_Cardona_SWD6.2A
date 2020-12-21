using ShoppingCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShoppingCart.Application.ViewModels
{
   public class OrderDetailsViewModel
    {
        [Key]
        public int Id { get; set; }


        //foreign key attribute
        public Guid ProductFk { get; set; }
       
        public ProductViewModel Product { get; set; }



        //foreign key attribute
        public Guid OrderFk { get; set; }
        public OrderViewModel Order { get; set; }


        public int Quantity { get; set; }

        public double Price { get; set; }

    }
}
