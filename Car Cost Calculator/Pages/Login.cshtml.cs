using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Car_Cost_Calculator.Pages
{
    public class LoginModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public User user { get; set; }

        [BindProperty(SupportsGet = true)]
        public Vehicle vehicle { get; set; }



        public void OnGet()
        {
        }

        public IEnumerable<User> Accounts
        {
            get { return new CarCostRepository().GetAccounts(); }
        }
        public IEnumerable<Vehicle> items
        {
            get { return new CarCostRepository().GetVehiclesByID(user.mail, user.password); }
        }

        public IActionResult OnPostLogin(string action = "")
        {
            if (ModelState.IsValid)
            {
                var ToVehicles = new CarCostRepository().GetVehiclesByID(user.mail, user.password);
                if (action == "Login")
                {
                    SetSession();
                }
                //return RedirectToPage("UserVehicles");
            }
            return Page();
        }

        public void SetSession()
        {
            HttpContext.Session.SetString("email", user.mail);
            HttpContext.Session.SetString("Password", user.password);
        }

        //Controleer de waarde in alle andere pagina's
        //Zet alle waardes in login
    }

}
