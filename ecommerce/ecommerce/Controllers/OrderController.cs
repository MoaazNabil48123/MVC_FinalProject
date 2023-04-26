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
        public OrderController(IRepository<ShopOrder> OrderRepo, UserManager<ApplicationUser> userManager)
        {
            this.OrderRepo = OrderRepo;
            this.userManager = userManager;
        }
		[Authorize]
		public async Task<IActionResult> Index()
		{
			ApplicationUser appUser = await userManager.FindByNameAsync(User.Identity.Name);
            ShopOrder shopOrder= new ShopOrder() { 
                UserId = appUser.Id,
                OrderDate = DateTime.Now,
                PaymentMethodId = 1,

            };
			return View(shopOrder);
		}
	}
}
