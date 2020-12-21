using ShoppingCart.Data.Context;
using ShoppingCart.Domain.Interfaces;
using ShoppingCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Data.Repositories
{
   public class OrdersRepository : IOrdersRepository
    {
        public ShoppingCartDbContext _context;
 
        public OrdersRepository(ShoppingCartDbContext context)
        {
            _context = context;
        }

        public void AddOrder(Order o)
        {
            _context.Orders.Add(o);
            _context.SaveChanges();
           
        }

        public void CheckOut(List<Product> productsInCart)
        {
            //still need to work on this one
            //Product showProduct = new Product();
            //return showProduct.Name;
        }
    }
}
