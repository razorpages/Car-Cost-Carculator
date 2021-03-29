using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Car_Cost_Calculator.Pages
{
    public class LoginModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public User account { get; set; }

        [BindProperty(SupportsGet = true)]
        public Vehicle vehicle { get; set; }

        [BindProperty(SupportsGet = true)]
        public string email { get; set; }

        public void OnGet()
        {

        }
        public IEnumerable<User> Accounts
        {
            get { return new CarCostRepository().GetAccounts(); }
        }
        public IEnumerable<Vehicle> items
        {
            get { return new CarCostRepository().GetVehiclesByID(email); }
        }


        public IActionResult OnGetLogin() 
        {
            if (ModelState.IsValid)
            {
                var ToVehicles = new CarCostRepository().GetVehiclesByID(vehicle.Account_ID);
            }
            return Page();
        }
    }
}
