using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Car_Cost_Calculator.Pages
{
    public class UpdateAccountModel : PageModel
    {
        public void OnGet()
        {
        }
        public User user { get; set; }
    }
}
