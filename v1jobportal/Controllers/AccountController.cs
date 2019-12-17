using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using v1jobportal.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using v1jobportal.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace v1jobportal.Controllers
{
    
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("index", "AllJobListings");

        }
        [AcceptVerbs("Get","Post")]
        [AllowAnonymous]
        public async Task<IActionResult> IsEmailInUse(string email)
        {
            var user = await userManager.FindByNameAsync(email);

            if (user == null)
            {
                return Json(true);
            }
            else
            {
                return Json($"Email { email} is already registered here, try anotehr email");
            }
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.Email, Email = model.Email };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    // Add all new users to the User role
                    await userManager.AddToRoleAsync(user,"User");
                    //ignore--await signInManager.SignInAsync(user, isPersistent: false);
                    if (user.Email.StartsWith("admin"))
                    {
                        await userManager.AddToRoleAsync(user, "Admin");
                    }

                    return RedirectToAction("index", "AllJobListings");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                
                var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                    
                {
                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        return LocalRedirect(returnUrl);
                    }
                    var result1 = await userManager.FindByEmailAsync(model.Email);
                    var roles = await userManager.GetRolesAsync(result1);
                    return RedirectToAction("Index", "AllJobListings");
                }

                    ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            }
            return View(model);
        }
        [AllowAnonymous]
        public IActionResult RessetPassword()
        {
            return View();
        }

        

    }
}
