using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Application.Interfaces;
using ShoppingCart.Application.Services;
using ShoppingCart.Application.ViewModels;

namespace Presentation.Controllers
{
    public class CategoriesController : Controller
    {
        private ICategoriesService _categoriesService;
   
        public CategoriesController(ICategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
     
        }
        /// <summary>
        /// Categories Catalogue - Filtering
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var list = _categoriesService.GetCategories();
 

            return View(list);
            
        }
    }
}
