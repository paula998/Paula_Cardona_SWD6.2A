using ShoppingCart.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Models
{
    public class CreateCartModel
    {

        public CartViewModel Cart { get; set; }
    }

    public class ListCartModel
    {
        public List<CartViewModel> carts { get; set; }
    }
}
