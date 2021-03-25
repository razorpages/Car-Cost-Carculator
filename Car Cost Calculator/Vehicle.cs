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
        [Required()]
        [BindProperty]
        public string Number_Plate { get; set; }

        [Required()]
        [BindProperty]
        public string Vehicle_Kind { get; set; }

        [Required()]
        [BindProperty]
        public string Account_ID { get; set; }

        [Required()]
        [BindProperty]
        public int Current_KM { get; set; }

        [Required()]
        [BindProperty]
        public DateTime BuyDate { get; set; }

        [Required()]
        [BindProperty]
        public double BuyCost { get; set; }
    }
}
