using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Cost_Calculator
{
    public class Vehicle
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your Number plate"), MinLength(2), MaxLength(40)]
        [BindProperty]
        public string Number_Plate { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your vehicle"), MinLength(2), MaxLength(40)]
        [BindProperty]
        public string Vehicle_Kind { get; set; }

        [BindProperty]
        public string Account_ID { get; set; }

        [BindProperty]
        public int Current_KM { get; set; }

        [BindProperty]
        public DateTime BuyDate { get; set; }

        [Required()]
        [BindProperty]
        public double BuyCost { get; set; }
    }
}
