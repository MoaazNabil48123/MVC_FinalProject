using ecommerce.Models;
using ecommerce.Repository;
using ecommerce.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        IRepository<Address> AddressRepo;
        IRepository<Country> CountryRepo;
        IRepository<ApplicationUser> ApplicationUserRepo;

        public AccountController(UserManager<ApplicationUser> _userManager,
            SignInManager<ApplicationUser> _signInManager
            , IRepository<Address> AddressRepo
            , IRepository<Country> CountryRepo
            , IRepository<ApplicationUser> ApplicationUserRepo
            )
        {
            userManager = _userManager;
            signInManager = _signInManager;
            this.AddressRepo = AddressRepo;
            this.CountryRepo = CountryRepo;
            this.ApplicationUserRepo = ApplicationUserRepo;
        }
        #region Regiser
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
        #endregion

        #region LogIn
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
                        return RedirectToAction("Index", "Home");
                    }
                }
                ModelState.AddModelError("", "Login Fail Data wrong");

            }
            return View(userVM);
        }
        #endregion

        #region SignOut
        public async Task<IActionResult> SignOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
        #endregion

        #region Address
        public async Task<IActionResult> Address()
        {
            AddressCountryViewModel ACVM = new AddressCountryViewModel();
            List<Country> CounteryList = CountryRepo.GetAll();
            ACVM.CountriesList = CounteryList;
            ACVM.previousUrl = HttpContext.Request.Headers["Referer"].ToString();

            return View(ACVM);
        }
        [HttpPost]
       
        public async Task<IActionResult> Address(AddressCountryViewModel ACVM)
        {
            ApplicationUser appUser = await userManager.FindByNameAsync(User.Identity.Name);

            if (ModelState.IsValid)
            {
                Address userModel = new Address();

                userModel.Id = ACVM.Id;
                userModel.UserId = appUser.Id;
                userModel.Unit_Number = ACVM.Unit_Number;
                userModel.Street_Number = ACVM.Street_Number;
                userModel.Address_line1 = ACVM.Address_line1;
                userModel.Address_line2 = ACVM.Address_line2;
                userModel.City = ACVM.City;
                userModel.Region = ACVM.Region;
                userModel.Postal_Code = ACVM.Postal_Code;
                userModel.Country_Id = ACVM.Country_Id;


               AddressRepo.Add(userModel);
                return Redirect(ACVM.previousUrl);

                // return RedirectToAction("Index", "Home");

                //save db
                //IdentityResult result =
                //    await userManager.CreateAsync(userModel, newUser.Password);
                //if (result.Succeeded)
                //{

                //    //        //await userManager.AddToRoleAsync(userModel, "Admin");

                //    await signInManager.SignInAsync(userModel, false);//create cookie //create cookie client
                //    return RedirectToAction("Index", "Home");
                //}
                //else
                //{
                //    foreach (var item in result.Errors)
                //    {
                //        ModelState.AddModelError("", item.Description);//Div
                //    }
                //}
            }
            return View("Address",ACVM);
        }
        #endregion
    }
}
