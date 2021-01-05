using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Application.Interfaces;
using ShoppingCart.Application.ViewModels;

namespace Presentation.Controllers
{
    public class CartsController : Controller
    {
        private ICartsService _cartsService;
        private IWebHostEnvironment _env;


        public CartsController(ICartsService cartsService, IWebHostEnvironment env)
        {
            _cartsService = cartsService;
            _env = env;
        }

        public IActionResult Index()
        {
            var list = _cartsService.GetProductsCart();

            return View(list);
        }

        public IActionResult Add(CartViewModel data)
        {
          
            _cartsService.AddCart(data);

            return View();
        }
    }
}
