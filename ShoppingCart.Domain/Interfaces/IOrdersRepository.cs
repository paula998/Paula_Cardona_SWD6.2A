using ShoppingCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Domain.Interfaces
{
   public interface IOrdersRepository
    {
        void CheckOut(List<Product> productsInCart);

        void AddOrder (Order o);
    }
}
