using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Car_Cost_Calculator.Pages
{
    public class TankCostByVehicleModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public Tank tank { get; set; }

        public void OnGet()
        {

        }

        public void OnGetMyTankCosts()
        {

        }

        //public IEnumerable<Tank> tanks
        //{
            //get { return new CostRepository().GetTankCosts(tank); }
        //}
    }
}
