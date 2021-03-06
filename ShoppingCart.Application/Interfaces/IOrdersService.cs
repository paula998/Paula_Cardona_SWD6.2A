﻿using ShoppingCart.Application.ViewModels;
using ShoppingCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Application.Interfaces
{
    public interface IOrdersService
    {
        void CheckOut(List<Product> productsInCart);

        void AddOrder(OrderViewModel o);

    }
}
