using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Car_Cost_Calculator.Pages
{
    public class UpdateVehicleModel : PageModel
    {
        [BindProperty]
        public Vehicle vehicle { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPostUpdate()
        {
            if (ModelState.IsValid)
            {
                new CarCostRepository().UpdateVehicle(vehicle);
                var AddRepository = new CarCostRepository().GetAllVehicles();
                return RedirectToPage("UserVehicles");
            }
            return Page();
        }
    }
}
