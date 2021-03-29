using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Car_Cost_Calculator.Pages
{
    public class UserVehiclesModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public User user { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public Vehicle vehicle { get; set; }

        public void OnGet()
        {
          
        }

        public IEnumerable<Vehicle> vehicles
        {
            get { return new CarCostRepository().GetAllVehicles(); }

            //get { return new CarCostRepository().GetVehiclesByID(vehicle.Account_ID); }
        }

        public IEnumerable<User> Accounts
        {
            get { return new CarCostRepository().GetAccounts(); }
        }


        public IActionResult OnGetUserItems()
        {
            if (ModelState.IsValid)
            {
                var AddRepository = new CarCostRepository().GetAllVehicles();
                //var AddRepository = new CarCostRepository().GetVehiclesByID(vehicle.Account_ID);
            }
            return Page();
        }
    }
}
