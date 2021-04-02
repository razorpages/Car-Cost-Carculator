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

        public void OnGet(string email)
        {
            //var GetVehicles = new CarCostRepository().GetVehiclesByID(user.mail);
        }

        public IEnumerable<Vehicle> vehicles
        {
            //get { return new CarCostRepository().GetAllVehicles(); }

            get { return new CarCostRepository().GetVehiclesByID(user.mail, user.password); }
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
                return Page();
            }
            return Page();
        }

        public void OnPostDelete()
        {
            var AddRepository = new CarCostRepository().DeleteVehicle(vehicle.Number_Plate);
        }
    }
}
