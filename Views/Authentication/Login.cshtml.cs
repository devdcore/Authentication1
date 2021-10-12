using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Authentication1.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;

namespace Authentication1.Views.Authentication
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<IdentityUser> signInManager;
        public Login Model { get; set; }

        public LoginModel(SignInManager<IdentityUser> signInManager)
        {
            this.signInManager = signInManager;
        }

        public void OnGet()
        {
        }

        //public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var identityResult = await signInManager.PasswordSignInAsync(Model.User, Model.Password, Model.RememberMe, false);
        //        if (identityResult.Succeeded)
        //        {
        //            if (returnUrl == null || returnUrl == "/")
        //            {
        //                RedirectToPage("Index");
        //            }
        //            else
        //            {
        //                RedirectToPage(returnUrl);
        //            }
        //        }

        //        ModelState.AddModelError("", "Usuario o password incorrectos");
        //    }
        //    return Page();
        //}
    }
}
