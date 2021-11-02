using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Login_MVC_.Models
{
    public class Account
    {
        public string Name { get; set; }
        [Required(ErrorMessage  = "please enter a valid user name")]
        public string Password { get; set; }
    }
}
