using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MarketPlaceProject.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email or Username is required.")]
        public string EmailOrUsername { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }
    }
}