using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Car_Cost_Calculator.Pages
{
    public class UpdateVehicleModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public Vehicle vehicle { get; set; }

        [BindProperty(SupportsGet = true)]
        public string UserPlate { get; set; }

        public void OnGet()
        {
           //HttpContext.Session.SetString("Userplate", vehicle.Number_Plate);
        }

        public IActionResult OnPostUpdate()
        {            

            if (ModelState.IsValid)
            {
                new CarCostRepository().UpdateVehicle(vehicle);
                //var AddRepository = new CarCostRepository().GetAllVehicles();
                return RedirectToPage("UserVehicles");
            }
            return Page();
        }
    }
}
