using ecommerce.Models;
using ecommerce.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;


        public UserController(UserManager<ApplicationUser> _userManager,
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
                    //        //await userManager.AddClaimAsync(userModel, new Claim("xyz","23"));
                    //        //await userManager.AddToRoleAsync(userModel, "Admin");
                    //        //------------------Create Cookie Authora
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
        public IActionResult Index()
        {
            return View();
        }
    }
}
