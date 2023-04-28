using ecommerce.Models;
using ecommerce.Repository;
using ecommerce.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Controllers;

public class UserController : Controller
{
    #region Constructor
    private UserManager<ApplicationUser> userManager;
    private IRepository<Country> countryRepo;
    private IRepository<Address> addressRepo;

    public UserController(UserManager<ApplicationUser> userManager,
        IRepository<Country> countryRepo,
        IRepository<Address> addressRepo)
    {
        this.userManager = userManager;
        this.countryRepo = countryRepo;
        this.addressRepo = addressRepo;
    }
    #endregion

    #region Update Profile Data
    [Authorize]
    public IActionResult Update()
    {
        ApplicationUser user = userManager.Users.Include(e => e.Addresses)
        .ThenInclude(address => address.Country).First(e => e.UserName == User.Identity.Name);
        //ApplicationUser user = userManager.Users.Include(appUser => appUser.Addresses)
        //    .ThenInclude(address => address.Country).First(e => e.UserName == "moaaz");
        UserProfil_VM model = new UserProfil_VM
        {
            UserName = user.UserName,
            Email = user.Email,
            Phone = user.PhoneNumber,
            addresses = user.Addresses
        };
        return View(model);
    }
    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Update(UserProfil_VM updatedUser)
    {
        ApplicationUser user = userManager.Users.Include(e => e.Addresses)
        .ThenInclude(address => address.Country).First(e => e.UserName == User.Identity.Name);
        //ApplicationUser user = userManager.Users.Include(appUser => appUser.Addresses)
        //    .ThenInclude(address => address.Country).First(e => e.UserName == "moaaz");
        if (ModelState.IsValid)
        {
            user.UserName = updatedUser.UserName;
            user.PhoneNumber = updatedUser.Phone;
            user.Email = updatedUser.Email;
            var result = await userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            else
            {
                TempData["Success"] = "Profile Data have been changed successfully";
                return RedirectToAction("Update");
            }
        }
        updatedUser.addresses = user.Addresses;
        return View(updatedUser);
    }
    #endregion

    #region Update & insert Address
    public IActionResult UpsertAddress(int? id)
    {
        Address model = new Address();
        List<Country> countryList = countryRepo.GetAll();
        ViewBag.countryList = countryList;

        if (id != null && id != 0)
        {
            model = addressRepo.GetById((int)id);
        }
        return View(model);
    }
    [HttpPost]
    [Authorize]
    public async Task<IActionResult> UpsertAddress(Address newAddress)
    {

        if (ModelState.IsValid)
        {
            if (newAddress.Id == 0) // add new address
            {
                ApplicationUser user  = await  userManager.FindByNameAsync(User.Identity.Name);
                //ApplicationUser user = await userManager.FindByNameAsync("moaaz");
                user.Addresses.Add(newAddress);
                var result = await userManager.UpdateAsync(user);
                if (!result.Succeeded)
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
                else
                {
                    TempData["Success"] = "Address's been added successfully";
                    return RedirectToAction("Update");
                }
            }
            else //update address
            {
                addressRepo.Update(newAddress);
                TempData["Success"] = "Address's been Updated successfully";
                return RedirectToAction("Update");
            }
        }
        List<Country> countryList = countryRepo.GetAll();
        ViewBag.countryList = countryList;
        return View(newAddress);
    }
    #endregion

    #region Delete Address
    public IActionResult DeleteAddress(int id)
    {
        addressRepo.Delete(addressRepo.GetById(id));
        TempData["Success"] = "Address's deleted successfully";
        return RedirectToAction("Update");
    }
    #endregion

    #region Set Address as default
    [Authorize]
    public async Task<IActionResult> SetAsDefault(int id)
    {
        ApplicationUser user = userManager.Users.Include(e => e.Addresses)
        .First(e => e.UserName == User.Identity.Name);
        //ApplicationUser user = userManager.Users.Include(appUser => appUser.Addresses)
        //    .First(e => e.UserName == "moaaz");
        foreach (Address address in user.Addresses)
        {
            if (address.Id == id)
            {
                address.IsDefault = true;
            }
            else
            {
                address.IsDefault = false;
            }
        }
        var result =await userManager.UpdateAsync(user);
        if (!result.Succeeded)
        {
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError("", item.Description);
            }
            TempData["Error"] = "Operation Failed";
            return RedirectToAction("Update");
        }
        else
        {
            TempData["Success"] = "Default address has been changed successfully";
            return RedirectToAction("Update");
        }

    }
    #endregion

    #region Change Password
    public IActionResult ChangePassword()
    {
        return View();
    }
    [Authorize]
    [HttpPost]
    public async Task<IActionResult> ChangePassword(ChangePassword_VM changePassword)
    {
        if (ModelState.IsValid)
        {
            ApplicationUser user =await userManager.FindByNameAsync(User.Identity.Name);
           // ApplicationUser user = await userManager.FindByNameAsync("moaaz");
            var result = await userManager.ChangePasswordAsync(user, changePassword.OldPassword, changePassword.NewPassword);
            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    switch (item.Code)
                    {
                        case "PasswordMismatch":
                            ModelState.AddModelError("OldPassword", item.Description);
                            break;
                        default:
                            ModelState.AddModelError("", item.Description);
                            break;
                    }
                }
            }
            else
            {
                TempData["Success"] = "Password's been changed successfully";
            }
        }
        return View();
    }
    #endregion

    //[Authorize]
    //public async Task<IActionResult> ChangeContent(string partialViewName)
    //{
    //    switch (partialViewName)
    //    {
    //        case "_ProfilePartial":
    //            //ApplicationUser user = await userManager.FindByNameAsync(User.Identity.Name);
    //            ApplicationUser user = await userManager.FindByNameAsync("moaaz");
    //            UserProfil_VM model = new UserProfil_VM { UserName = user.UserName, Email = user.Email, Phone = user.PhoneNumber };
    //            return PartialView("_ProfilePartial", model);
    //        case "_ChangePasswordPartial":
    //            return PartialView("_ChangePasswordPartial");
    //        case "_AddAddressPartial":
    //            List<Country> countryList = countryRepo.GetAll();
    //            ViewBag.countryList = countryList;
    //            return PartialView("_AddAddressPartial");
    //        default:
    //            return PartialView("_ProfilePartial");
    //    }
    //}
}
