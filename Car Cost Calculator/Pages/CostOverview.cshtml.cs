using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Car_Cost_Calculator.Pages
{
    public class CostOverviewModel : PageModel
    {
        public void OnGet()
        {
        }

        public IEnumerable<Vehicle> vehicles
        {
            get { return new CarCostRepository().GetVehiclesByID(HttpContext.Session.GetString("email"), HttpContext.Session.GetString("password")); }
        }

        public IEnumerable<Costs> Info 
        {
            get { return new CostRepository().GetCosts(); }
        }
    }
}
