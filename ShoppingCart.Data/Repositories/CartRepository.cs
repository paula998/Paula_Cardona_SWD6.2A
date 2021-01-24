using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ShoppingCart.Data.Context;
using ShoppingCart.Domain.Interfaces;
using ShoppingCart.Domain.Models;

namespace ShoppingCart.Data.Repositories
{
    public class CartRepository : ICartRepository
    {
        private ShoppingCartDbContext _context;

        public CartRepository(ShoppingCartDbContext context)
        {
            _context = context;
        }

        public void AddToCart(CartD c)
        {
            _context.CartDetails.Add(c);
            _context.SaveChanges();
             
        }

        public CartD GetCart(string email, Guid productId)
        {
            return _context.CartDetails.SingleOrDefault(x => x.CartId == productId); 
        }
       
        public void UpdateCart(CartD c)
        {
            _context.Update(c);
            _context.SaveChanges();
        }
    }
}
