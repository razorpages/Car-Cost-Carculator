using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Car_Cost_Calculator.Pages
{
    public class FuelCostInputModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public Tank tank { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPostAddTankCost() 
        {
            if (ModelState.IsValid)
            {
                new CostRepository().TankCostAdd(tank);
                return Page();
            }
            return Page();
        }

        public IEnumerable<Vehicle> vehicles
        {
            get { return new CarCostRepository().GetVehiclesByID(HttpContext.Session.GetString("email"), HttpContext.Session.GetString("password")); }
        }
    }
}
