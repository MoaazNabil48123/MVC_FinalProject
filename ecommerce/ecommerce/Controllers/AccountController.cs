using ecommerce.Models;
using ecommerce.Repository;
using ecommerce.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ecommerce.Controllers;

public class AccountController : Controller
{
    #region Constructor
    private readonly UserManager<ApplicationUser> userManager;
    private readonly SignInManager<ApplicationUser> signInManager;
    IRepository<Address> AddressRepo;
    IRepository<Country> CountryRepo;

    public AccountController(UserManager<ApplicationUser> _userManager,
        SignInManager<ApplicationUser> _signInManager
        , IRepository<Address> AddressRepo
        , IRepository<Country> CountryRepo
        )
    {
      
        userManager = _userManager;
        signInManager = _signInManager;
        this.AddressRepo = AddressRepo;
        this.CountryRepo = CountryRepo;

    }
    #endregion

    #region Register
    public IActionResult Register()
    {
        return View();
    }
    [HttpPost]
    //[ValidateAntiForgeryToken]
    public async Task<IActionResult> Register(RegisterViewModel newUser)
    {
        if (ModelState.IsValid)
        {
            ApplicationUser userModel = new ApplicationUser();
            userModel.UserName = newUser.UserName;
            userModel.Email = newUser.EmailAddress;
            userModel.PasswordHash = newUser.Password;
            userModel.PhoneNumber = newUser.PhoneNumber;

            IdentityResult result =await userManager.CreateAsync(userModel, newUser.Password);
            if (result.Succeeded)
            {
                //await userManager.AddToRoleAsync(userModel, "Admin");
                await signInManager.SignInAsync(userModel, false);
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

    #region SignIn
    public async Task<IActionResult> Login(string? returnUrl)

    {
        LoginViewModel model = new LoginViewModel
        {
        previousUrl = HttpContext.Request.Headers["Referer"].ToString(),
        ReturnUrl = returnUrl,
            ExternalLogins = (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
        };
        return View(model);
    }

    [HttpPost]
    //[ValidateAntiForgeryToken]
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

                    return Redirect(userVM.previousUrl);
                }
            }
            ModelState.AddModelError("", "Login Fail Data wrong");

        }
  
        return RedirectToAction("Login");
    }
    #endregion

    #region SignOut

    public async Task<IActionResult> SignOut()
    {
        await signInManager.SignOutAsync();
        return RedirectToAction("Index", "Home");
    }
    #endregion

    #region External Login
    [HttpPost]
    public IActionResult ExternalLogin(string provider, string returnUrl)
    {
        var redirectUrl = Url.Action("ExternalLoginCallBack", "Account", new { ReturnUrl = returnUrl });
        var properties = signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
        return new ChallengeResult(provider, properties);
    }
    public async Task<IActionResult> ExternalLoginCallBack(string returnUrl=null, string remoteError =null)
    {
        returnUrl = returnUrl ?? Url.Content("~/"); // if returnUrl = null return the root page

        #region if there is error received from the external provider then return the login page again
        LoginViewModel model = new LoginViewModel
        {
            ReturnUrl = returnUrl,
            ExternalLogins = (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
        };
        if (remoteError != null)  
        {
            ModelState.AddModelError("", $"Error from external provider {remoteError}");
            return View("Login", model);
        }
        #endregion

        #region if you received empty information from the external provider then return the login page 
        //if there is no errors recieved from the external provider
        //get external login information from the external provider
        var info = await signInManager.GetExternalLoginInfoAsync();
        if (info == null) //if there is no info
        {
            ModelState.AddModelError("", "Error loading the external login information.");
            return View("Login", model);
        }
        #endregion

        #region if the info isn't empty and the login process succeded
        //you should be a local user ( having a row in AspNetUser) and each local user
        //has many rows in "AspNetUserLogin" which are the external login accounts of this user
        //so if you aren't a local user and have this account stored in "AspNetUserLogin" table 
        //this signin process will fail
        var signinResult = await signInManager.ExternalLoginSignInAsync(info.LoginProvider,
                info.ProviderKey, isPersistent: false, bypassTwoFactor: true);
        if (signinResult.Succeeded)
        {
            return LocalRedirect(returnUrl);
        }
        #endregion

        #region check if we have local user with this email
        else
        {
            var email = info.Principal.FindFirstValue(ClaimTypes.Email);// get the email
            if (email != null)
            {
                var user = await userManager.FindByEmailAsync(email);
                if (user == null)
                {
                    //in this case we don't have external login info match with this info 
                    // and also don't have local user have this email so create new local user with this info
                    //then attach to him the external login info and create cookie
                    user = new ApplicationUser
                    {
                        UserName = info.Principal.FindFirstValue(ClaimTypes.Name),
                        Email = info.Principal.FindFirstValue(ClaimTypes.Email)
                    };
                    await userManager.CreateAsync(user);
                }
                //if we have local user with the same email so attach the external login info 
                //to that user in "AspNetUserLogin" and then create the cookie for him 
                userManager.AddLoginAsync(user, info);
                signInManager.SignInAsync(user, isPersistent: false);
                return LocalRedirect(returnUrl);

            }
            else 
            {
                //if the email is null 
                ModelState.AddModelError("", $"Email Claim not received from {info.LoginProvider}");
                return View("Login", model);

            }

        }
        #endregion

        //received error ==> go back to login page
        //received empty info ==> go back to login page
        //received info with no email ==> go back to login page
        //you have login info ==> signin
        //you don't have login info ==>
        //     1) we have signin info with the same email in "AspNetUser", then create login info "AspNetUserLogin" then signin(create cookie)
        //  or 2) we don't have signin info for this email, then create local user and his login info and signin(create cookie)
    }
    #endregion

    #region Address
    [Authorize]
    public async Task<IActionResult> Address()
    {
        ApplicationUser appUser = await userManager.FindByNameAsync(User.Identity.Name);
        AddressCountryViewModel ACVM = new AddressCountryViewModel();
        ACVM.UserId = appUser.Id;
        List<Country> CounteryList = CountryRepo.GetAll();
        ACVM.CountriesList = CounteryList;
        ACVM.previousUrl = HttpContext.Request.Headers["Referer"].ToString();

        return View(ACVM);
    }
    [HttpPost]
    
    public async Task<IActionResult> Address(AddressCountryViewModel ACVM)
    {
        if (ModelState.IsValid)
        {
            Address userModel = new Address();


            userModel.Id = ACVM.Id;
            userModel.UserId = ACVM.UserId;
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
