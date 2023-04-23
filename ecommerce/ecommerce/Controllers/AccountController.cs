using ecommerce.Models;
using ecommerce.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;


        public AccountController(UserManager<ApplicationUser> _userManager,
            SignInManager<ApplicationUser> _signInManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;

        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel newUser)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser userModel = new ApplicationUser();
                  userModel.UserName = newUser.UserName;
                  userModel.Email = newUser.EmailAddress;
               //   userModel.Address = newUser.Address;
                  userModel.PasswordHash = newUser.Password;
                  userModel.PhoneNumber = newUser.PhoneNumber;

                //save db
                   IdentityResult result =
                       await userManager.CreateAsync(userModel, newUser.Password);
                if (result.Succeeded)
                {
                  
                    //        //await userManager.AddToRoleAsync(userModel, "Admin");
                    
                    await signInManager.SignInAsync(userModel, false);//create cookie //create cookie client
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (var item in result.Errors)
                        {
                           ModelState.AddModelError("", item.Description);//Div
                        }
                }
            }
            return View(newUser);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel userVM)
        {
            if (ModelState.IsValid)
            {
                //Check Valid User ==>db
                ApplicationUser userModel =
                    await userManager.FindByNameAsync(userVM.UserName);
                if (userModel != null)
                {
                    bool found = await userManager.CheckPasswordAsync(userModel, userVM.Password);
                    if (found)
                    {
                        //cookie
                        await signInManager.SignInAsync(userModel, userVM.RememberMe);
                        return RedirectToAction("Index", "Order");
                    }
                }
                ModelState.AddModelError("", "Login Fail Data wrong");

            }
            return View(userVM);
        }
        public async Task<IActionResult> SignOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
