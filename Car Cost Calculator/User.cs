using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Cost_Calculator
{
    public class User
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your e-mailaddress"), MinLength(2), MaxLength(40)]
        [BindProperty]
        public string mail { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your full name"), MinLength(2), MaxLength(40)]
        [BindProperty]
        public string full_name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter a password"), MinLength(2), MaxLength(40)]
        [BindProperty]
        public string password { get; set; }
    }
}
