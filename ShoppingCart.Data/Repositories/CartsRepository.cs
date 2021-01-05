﻿using Microsoft.EntityFrameworkCore;
using ShoppingCart.Data.Context;
using ShoppingCart.Domain.Interfaces;
using ShoppingCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.Data.Repositories
{
    public class CartsRepository : ICartsRepository
    {
        private ShoppingCartDbContext _context;

        public CartsRepository(ShoppingCartDbContext context)
        {
            _context = context;  
        }

        public void AddItem(Cart c)
        {
            _context.CartDetails.Add(c);
        }

        public IQueryable<Cart> GetProductsCart()
        {
            return _context.CartDetails;
        }
    }
}
