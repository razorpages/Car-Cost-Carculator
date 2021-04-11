using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Car_Cost_Calculator.Pages
{
    public class CostInputModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public Costs costs { get; set; }

        public void OnGet()
        {

        }

        public IActionResult OnPostAddCost()
        {
            if (ModelState.IsValid)
            {
                var Addcost = new CostRepository().CostsAdd(costs);
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
