using Authentication1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication1.Controllers
{
    public class Authentication : Controller
    {
        private readonly UserManager<ExtraInfoUser> userManager;
        private readonly SignInManager<ExtraInfoUser> signInManager;

        [BindProperty]
        public Register RegisterModel { get; set; }
        [BindProperty]
        public Login LoginModel { get; set; }

        public Authentication(UserManager<ExtraInfoUser> userManager, SignInManager<ExtraInfoUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        //public IActionResult Register_()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> testPost([FromForm]List<Register> data)
        //{
        //    return Json("");
        //}


        [HttpPost]
        public async Task<IActionResult> LoginPost([FromBody] List<Login> data, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                var identityResult = await signInManager.PasswordSignInAsync(LoginModel.User, LoginModel.Password, LoginModel.RememberMe, false);
                if (identityResult.Succeeded)
                {
                    if (returnUrl == null || returnUrl == "/")
                    {
                        RedirectToAction("Index");
                    }
                    else
                    {
                        RedirectToAction(returnUrl);
                    }
                }

                ModelState.AddModelError("", "Usuario o password incorrectos");
            }
            return View("Login");
        }

        [HttpPost]
        public async Task<IActionResult> testPostR()
        {

            if (ModelState.IsValid)
            {
                var ph = new PasswordHasher<ExtraInfoUser>();
                var user = new ExtraInfoUser()
                {
                    Country = RegisterModel.Country,
                    CID = RegisterModel.CID,
                    Treatment = RegisterModel.Treatment,
                    FirstName = RegisterModel.FirstName,
                    LastName = RegisterModel.LastName,
                    LastName2 = RegisterModel.LastName2,
                    BirthDate = RegisterModel.BirthDate,
                    Nationality = RegisterModel.Nationality,
                    Address = RegisterModel.Address,
                    Address2 = RegisterModel.Address2,
                    ZipCode = RegisterModel.ZipCode,
                    TaxResidence = RegisterModel.TaxResidence,
                    TaxResidence2 = RegisterModel.TaxResidence2,
                    NumberSecurity = RegisterModel.NumberSecurity,
                    ReceiveOffers = RegisterModel.ReceiveOffers,
                    TermsConditions = RegisterModel.TermsConditions,
                    TermsConditions2 = RegisterModel.TermsConditions,
                    UserName = RegisterModel.UserName,
                    Email = RegisterModel.Email
                };
                var passwordHash = ph.HashPassword(user, RegisterModel.Password);
                user.PasswordHash = passwordHash;

                var result = await userManager.CreateAsync(user, passwordHash);
                if (result.Succeeded)
                {

                    await signInManager.SignInAsync(user, false);
                    return RedirectToPage("Index");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View("Register");
        }
    }
}
