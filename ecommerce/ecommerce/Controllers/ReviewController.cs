using ecommerce.Models;
using ecommerce.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace ecommerce.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IRepository<Review> ReviewRepo;
        private readonly IRepository<Product> ProductRepo;
        private UserManager<ApplicationUser> UserManager;
        public ReviewController(IRepository<Review> reviewRepo, IRepository<Product> productRepo, UserManager<ApplicationUser> userManager)
        {
            ReviewRepo = reviewRepo;
            ProductRepo = productRepo;
            UserManager= userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> AddReview(int productId,string Comment)
        {
            ApplicationUser appUser = await UserManager.FindByNameAsync(User.Identity.Name);
            Review review = new Review();
            review.Comment = Comment;
            review.ProductId = productId;
            review.UserId = appUser.Id;
            review.CreatedOn = DateTime.Now;
            ReviewRepo.Add(review);
            return RedirectToAction("Details","Product", new { productId = productId });

        }
    }
}
