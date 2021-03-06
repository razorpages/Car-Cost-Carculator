using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Car_Cost_Calculator.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public User user { get; set; }

        public IEnumerable<User> users 
        {
            get { return new CarCostRepository().GetAccounts(); }
        }

        public void OnGet()
        {
        }

        public IActionResult OnPostRegister() 
        {
            if (ModelState.IsValid)
            {
                var existcheck = new CarCostRepository().CheckAccountExist(user);
                if (existcheck == false)
                {
                    var Register = new CarCostRepository().Register(user);
                    SetSession();
                    return RedirectToPage("Instructions");
                }
                else 
                {
                    ModelState.AddModelError("Error", "Email is already in use.");
                }

            }
            return Page();
        }

        public void SetSession() 
        {
            HttpContext.Session.SetString("email", user.mail );
            HttpContext.Session.SetString("password", user.password );
        }
    }
}
