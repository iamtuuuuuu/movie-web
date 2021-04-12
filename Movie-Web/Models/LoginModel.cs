using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movie_Web.Models
{
    public class LoginModel
    {
        
        public string UserName { set; get; }
        [Required(ErrorMessage = "Please enter email")]
        public string Email { set; get; }
        [Required(ErrorMessage = "Please enter password")]
        public string Password { set; get; }
    }
}