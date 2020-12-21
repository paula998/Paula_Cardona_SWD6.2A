﻿using ShoppingCart.Application.Interfaces;
using ShoppingCart.Application.ViewModels;
using ShoppingCart.Domain.Interfaces;
using ShoppingCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Application.Services
{
    public class OrdersService : IOrdersService
    {

        private IOrdersRepository _orderRepo;

        public OrdersService(IOrdersRepository orderRepo)
        {
            _orderRepo = orderRepo;
        }

        public void AddOrder(OrderViewModel o)
        {
            
        }

        public void CheckOut(List<Product> productsInCart)
        {
            throw new NotImplementedException();
        }
    }
}
