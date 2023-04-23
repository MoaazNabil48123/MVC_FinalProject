using ecommerce.Models;
using ecommerce.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;


namespace ecommerce.Controllers
{
    public class OrderController : Controller
    {
        private UserManager<ApplicationUser> userManager;

        private IRepository<ShopOrder> OrderRepo;
        public OrderController(IRepository<ShopOrder> OrderRepo)
        {
            this.OrderRepo = OrderRepo;
        }
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index()
        {
			ApplicationUser appUser = await userManager.GetUserAsync(User);
            ShopOrder shopOrder = new ShopOrder()
            {
                UserId = appUser.Id,
                OrderDate = DateTime.Now,
                ShippingAddressId = appUser.User_Addresses.First(/*c=>c.IsDefault==true*/).Address_Id,

				OrderStatusId = 1,
			};
            OrderRepo.Add(shopOrder);

			return View(shopOrder);
        }
    }
}
