using ecommerce.Models;
using ecommerce.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Controllers
{
    public class CartController : Controller
    {
		#region Constructor
		private UserManager<ApplicationUser> userManager;
		private IRepository<CartProducts> cartProductsRepo;

		public CartController(UserManager<ApplicationUser> userManager, IRepository<CartProducts> cartProductsRepo)
		{
			this.userManager = userManager;
			this.cartProductsRepo = cartProductsRepo;
		}
		#endregion

		#region Display all cart products
		//[Authorize]
		public IActionResult Index()
		{
			//ApplicationUser user = userManager.Users.Include(user => user.CartProducts)
			//    .ThenInclude(cartProduct => cartProduct.ProductItem)
			//    .ThenInclude(productItem => productItem.Product)
			//    .First(user => user.UserName == User.Identity.Name);
			ApplicationUser user = userManager.Users.Include(user => user.CartProducts)
				.ThenInclude(cartProduct => cartProduct.ProductItem)
				.ThenInclude(productItem => productItem.Product)
				.First(user => user.UserName == "moaaz");
			return View(user.CartProducts);
		}
		#endregion

		#region Delete Product from cart
		public async Task<IActionResult> DeleteProduct(int id)
		{
			CartProducts productToDelete = cartProductsRepo.GetById(id);
			cartProductsRepo.Delete(productToDelete);
			TempData["Success"] = "Product's been removed from the cart successfully.";
			return RedirectToAction("Index");
		}
		#endregion

		#region Change product quantity in cart
		public IActionResult ChangeQuantity(int cartProductId, int newQuantity)
		{
			CartProducts cartProduct = cartProductsRepo.GetById(cartProductId);
			cartProduct.Quantity = newQuantity;
			cartProductsRepo.Update(cartProduct);
			return Json(true);
		}
		#endregion
	}
}
