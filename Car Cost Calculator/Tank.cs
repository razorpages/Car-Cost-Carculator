using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_Cost_Calculator
{
    public class Tank
    {
        [Required()]
        [BindProperty]
        public int Tank_ID { get; set; }

        [Required()]
        [BindProperty]
        public int Before_Tank_KM { get; set; }

        [Required()]
        [BindProperty]
        public int After_Tank_KM { get; set; }

        [Required()]
        [BindProperty]
        public double Tank_Cost { get; set; }

        [Required()]
        [BindProperty]
        public DateTime Tank_Date { get; set; }

        [Required()]
        [BindProperty]
        public string Vehicle_KM  { get; set; }
    }
}
