using ecommerce.Models;
using ecommerce.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> AddReview(int productId,string comment)
        {
           ApplicationUser appUser = await UserManager.FindByNameAsync(User.Identity.Name);
            Review review = new Review();
            review.Comment = comment;
            review.ProductId = productId;
            review.UserId =appUser.Id;
            review.CreatedOn= DateTime.Now;
            ReviewRepo.Add(review);
            return View($"~/Views/Product/Details?productId={productId}");

        }
    }
}
