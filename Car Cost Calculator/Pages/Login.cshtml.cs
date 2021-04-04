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
            HttpContext.Session.Remove("email");
        }

        public IEnumerable<User> Accounts
        {
            get { return new CarCostRepository().GetAccounts(); }
        }
        public IEnumerable<Vehicle> items
        {
            get { return new CarCostRepository().GetVehiclesByID(user.mail, user.password); }
        }


        public IActionResult OnPostCheckLogin() 
        {  
                var checkexist = new CarCostRepository().CheckAccountLogin(user);

                if (checkexist == true)
                {
                    SetSession();
                    return RedirectToPage("UserVehicles");
                }
                else 
                {
                    ModelState.AddModelError("Error", " User does not exist, or incorrect input. ");
                }

            return Page();
        }

        public void SetSession()
        {
            HttpContext.Session.SetString("email", user.mail);
            HttpContext.Session.SetString("password", user.password);
        }

        //Controleer de waarde in alle andere pagina's
        //Zet alle waardes in login
    }

}
