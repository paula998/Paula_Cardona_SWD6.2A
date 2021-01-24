using ShoppingCart.Application.ViewModels;
using ShoppingCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.Application.Interfaces
{
  public interface ICartsService
    {
        void AddToCart(string email, Guid productId, int qty);

        void UpdateQtyInCart(string email, Guid productId, int qty);

    }
}
