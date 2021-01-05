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
        private ICartsRepository _cartsRepo;
        private IMapper _mapper;

        public CartsService(ICartsRepository cartsRepo, IMapper mapper)
        {
            _cartsRepo = cartsRepo;
            _mapper = mapper;
        }

        public void AddCart(CartViewModel data)
        {
            var c = _mapper.Map<Cart>(data);
            _cartsRepo.AddItem(c);
        }

        public IQueryable<CartViewModel> GetProductsCart()
        {
            return _cartsRepo.GetProductsCart().ProjectTo<CartViewModel>(_mapper.ConfigurationProvider);
        }

    
        
    }
}
