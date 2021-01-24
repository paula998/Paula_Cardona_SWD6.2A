using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.Domain.Models;

namespace ShoppingCart.Domain.Interfaces
{
   public interface ICartRepository
    {
        void AddToCart(CartD c);

        void UpdateCart(CartD c);

        CartD GetCart(string email, Guid productId);
        
    }
}
