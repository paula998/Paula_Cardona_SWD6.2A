using AutoMapper;
using AutoMapper.QueryableExtensions;
using ShoppingCart.Application.Interfaces;
using ShoppingCart.Application.ViewModels;
using ShoppingCart.Domain.Interfaces;
using ShoppingCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.Application.Services
{
    public class CartsService : ICartsService
    {
        private ICartRepository _cartRepo;
        private IMapper _mapper;

        public CartsService(ICartRepository cartRepo, IMapper mapper)
        {
            _cartRepo = cartRepo;
            _mapper = mapper;
        }

        public void AddToCart(string email, Guid productId, int qty)
        {
            CartD c = _cartRepo.GetCart(email, productId);

            if (c == null)
            {
                _cartRepo.AddToCart(new CartD()
                {
                    UserEmail = email,
                    ProductId_FK = productId, Quantity = qty
                });
            }
            else
            {
                UpdateQtyInCart(email, productId, qty);
            }
        }

        public void UpdateQtyInCart(string email, Guid productId, int qty)
        {
            CartD originalCart = null;

            originalCart.Quantity = qty;

            _cartRepo.UpdateCart(originalCart);
        }
    }
}
