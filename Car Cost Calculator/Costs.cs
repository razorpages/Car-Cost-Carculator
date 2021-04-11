using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Car_Cost_Calculator
{
    public class Costs
    {
        [BindProperty]
        public int Cost_ID { get; set; }

        [Required()]
        [BindProperty]
        public string Cost_Name { get; set; }

        [Required()]
        [BindProperty]
        public double Cost_Amount { get; set; }

        [Required()]
        [BindProperty]
        public DateTime Cost_Date { get; set; }

        [BindProperty]
        public string Vehicle_Cost { get; set; }
    }
}
