﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Application.Interfaces;
using ShoppingCart.Data.Context;

namespace Presentation.Controllers
{
    public class CartController : Controller
    {

        public IActionResult Index()
        {
          
            return View();
        }
    }
}
