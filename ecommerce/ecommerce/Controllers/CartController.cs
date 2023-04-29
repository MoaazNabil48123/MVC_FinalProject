using ecommerce.Models;
using ecommerce.Repository;
using Microsoft.AspNetCore.Authorization;
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
		private IRepository<Coupon> couponRepo;

		public CartController(UserManager<ApplicationUser> userManager,
			IRepository<CartProducts> cartProductsRepo,
			IRepository<Coupon> couponRepo)
		{
			this.userManager = userManager;
			this.cartProductsRepo = cartProductsRepo;
			this.couponRepo = couponRepo;
		}
		#endregion

		#region Display all cart products
		[Authorize]
		public IActionResult Index()
		{
			ApplicationUser user = userManager.Users.Include(user => user.CartProducts)
				.ThenInclude(cartProduct => cartProduct.ProductItem)
				.ThenInclude(productItem => productItem.Product)
				.First(user => user.UserName == User.Identity.Name);
			//ApplicationUser user = userManager.Users.Include(user => user.CartProducts)
			//	.ThenInclude(cartProduct => cartProduct.ProductItem)
			//	.ThenInclude(productItem => productItem.Product)
			//	.First(user => user.UserName == "moaaz");
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

		#region Check Coupon
		public IActionResult CheckCoupon(string couponName)
		{
			Coupon coupon = couponRepo.Get(coupon => coupon.Name == couponName.Normalize()).FirstOrDefault();
			if (coupon is null)
			{
				return Json(new
				{
					status = false,
					message = "Not Valid Coupon"
				});
			}
			if (coupon.ExpirationDate > DateTime.Now)
			{
				return Json(new
				{
					status = true,
					message = $"you got {Math.Round(coupon.Reduction * 100)}% off",
					reduction = Math.Round(coupon.Reduction,2)
				});
			}
			return Json(new
			{
				status = false,
				message = "Expired Coupon"
			});
		}
		#endregion

		#region Add to cart
		public IActionResult AddToCart()
		{
			return Json(true);
		}
		#endregion
	}
}
