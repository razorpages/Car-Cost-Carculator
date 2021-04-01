using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Car_Cost_Calculator.Pages
{
    public class MyAccountModel : PageModel
    {

        public User user { get; set; }
        public Vehicle Vehicle { get; set; }

        public void OnGet()
        {
            //var GetUserItems = new CarCostRepository().GetVehiclesByID(user.mail);
        }

        public IEnumerable<Vehicle> Vehicles
        {
            get { return new CarCostRepository().GetVehiclesByID(user.mail, user.password); }
        }

    }
}
