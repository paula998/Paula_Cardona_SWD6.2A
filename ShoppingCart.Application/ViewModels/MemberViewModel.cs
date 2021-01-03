using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShoppingCart.Application.ViewModels
{
    public  class MemberViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter your name")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter your last name")]
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
