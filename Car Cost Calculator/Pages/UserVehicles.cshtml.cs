using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
            var usermail = HttpContext.Session.GetString("email");
            var password = HttpContext.Session.GetString("password");
            vehicle.Account_ID = usermail;
        }

        public IEnumerable<Vehicle> vehicles
        {
            //get { return new CarCostRepository().GetAllVehicles(); }

            get { return new CarCostRepository().GetVehiclesByID(HttpContext.Session.GetString("email"), HttpContext.Session.GetString("password")); }
        }

        public IEnumerable<User> Accounts
        {
            get { return new CarCostRepository().GetAccounts(); }
        }


        //CRUD

        public IActionResult OnPostAdd() 
        {
            
            if (ModelState.IsValid) 
            {   
                var AddVehicle = new CarCostRepository().VehicleAdd(vehicle);
            }
            return Page();
        }

        public void OnPostDelete(string numberPlate)
        {
            new CarCostRepository().DeleteVehicle(numberPlate);
        }
    }
}
