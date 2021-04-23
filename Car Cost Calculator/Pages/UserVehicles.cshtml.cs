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
        public Vehicle vehicle { get; set; }

        public void OnGet()
        {

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

        public string GetCosts() 
        {
            var total = new CostRepository().TotalCost(HttpContext.Session.GetString("email"));
            return total.ToString();
        }

        //CRUD

        public IActionResult OnPostAdd() 
        {
            vehicle.Account_ID = HttpContext.Session.GetString("email");
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

        public void GetSession() 
        {

            var usermail = HttpContext.Session.GetString("email");
            var password = HttpContext.Session.GetString("password");
            vehicle.Account_ID = usermail;
        }
    }
}
