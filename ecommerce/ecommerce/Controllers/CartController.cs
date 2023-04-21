using ecommerce.Models;
using ecommerce.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
	public class CartController : Controller
	{
		private UserManager<ApplicationUser> userManager;
		private IRepository<CartProducts> cartProductsRepo;

		public CartController(UserManager<ApplicationUser> userManager,IRepository<CartProducts> cartProductsRepo)
		{
			this.userManager = userManager;
			this.cartProductsRepo = cartProductsRepo;
		}

		[Authorize]
		public async Task<IActionResult> Index()
		{
			ApplicationUser appUser = await userManager.FindByNameAsync(User.Identity.Name);
			return View(appUser.CartProducts);
		}
		public async Task<IActionResult> DeleteProduct(int id)
		{
			CartProducts productToDelete = cartProductsRepo.GetById(id);
			cartProductsRepo.Delete(productToDelete);
			return RedirectToAction("Index");
		}
	}
}
