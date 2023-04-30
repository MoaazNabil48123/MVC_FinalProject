using ecommerce.Models;
using ecommerce.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ecommerce.Controllers
{
    public class ProductController : Controller
    {
        IRepository<Product> ProductRepo;
        IRepository<Variation> VariationRepo;
        IRepository<ProductItem> ProductItemRepo;
        private UserManager<ApplicationUser> userManager;
        IRepository<Review> ReviewRepo;

        public ProductController(IRepository<Product> ProductRepo,
            IRepository<Variation> VariationRepo,
            IRepository<ProductItem> ProductItemRepo,
            UserManager<ApplicationUser> userManager,
            IRepository<Review> ReviewRepo)
        {
            this.ProductRepo = ProductRepo;
            this.VariationRepo = VariationRepo;
            this.ProductItemRepo = ProductItemRepo;
            this.userManager = userManager;
            this.ReviewRepo = ReviewRepo;
        }

        public IActionResult Index(int categoryId)
        {
            var x = ProductRepo.GetAll(p => p.ProductItems).Where(p => p.CategoryId == categoryId).ToList();

            return View(x);
        }
        public IActionResult Details(int productId)
        {
            Product product = ProductRepo.GetById(productId, p => p.Category, p => p.ProductItems, p => p.Reviews);
            if (User.Identity.IsAuthenticated)
            {
                ApplicationUser user = userManager.Users.Include(user => user.Products)
                    .First(user => user.UserName == User.Identity.Name);
                if (user.Products.Contains(product))
                {
                    ViewBag.isAddedToFavorites = true;
                }
                else
                {
                    ViewBag.isAddedToFavorites = false;
                }
            }
            else
            {
                ViewBag.isAddedToFavorites = false;
            }
            List<Review> review = ReviewRepo.GetAll(p => p.User);
            IEnumerable<Review> reviewsWithUserAndProduct = review.Where(review => review.ProductId == productId);
            //List<Variation> variations =VariationRepo.GetAll(v=>v.CategoryId==product.CategoryId);
            List<Variation> variationWithOptions = VariationRepo.GetAll(v => v.VariationOptions)
                .Where(variation => variation.CategoryId == product.CategoryId).ToList();
            //ViewData["variations"] = variations;
            List<ProductItem> productItems = ProductItemRepo.GetAll(p => p.ProductConfigurations);
            var selectedproductItems = productItems.Where(p => p.ProductId == productId);
            ViewData["variationWithOptions"] = variationWithOptions;
            ViewData["selectedproductItems"] = selectedproductItems;
            ViewData["reviewsWithUserAndProduct"] = reviewsWithUserAndProduct;
            return View(product);
        }
        [Authorize]
        public async Task<IActionResult> AddReview(int productId, string Comment)
        {
            //string comment = "This is Good";
            ApplicationUser appUser = await userManager.FindByNameAsync(User.Identity.Name);
            Review review = new Review();
            review.Comment = Comment;
            review.ProductId = productId;
            review.UserId = appUser.Id;
            review.CreatedOn = DateTime.Now;
            ReviewRepo.Add(review);
            return RedirectToAction("Details", new { productId = productId });


        }

    }
}
