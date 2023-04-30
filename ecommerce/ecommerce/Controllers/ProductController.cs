using ecommerce.Models;
using ecommerce.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace ecommerce.Controllers
{
	public class ProductController : Controller
    {
         IRepository<Review> ReviewRepo;
        IRepository<Product> ProductRepo;
		IRepository<Variation> VariationRepo;
		IRepository<ProductItem> ProductItemRepo;
        private UserManager<ApplicationUser> UserManager;
        public ProductController(IRepository<Product> ProductRepo, IRepository<Variation> VariationRepo, IRepository<ProductItem> ProductItemRepo, IRepository<Review> ReviewRepo,  UserManager<ApplicationUser> UserManager)
		{
			this.ReviewRepo = ReviewRepo;
			this.ProductRepo = ProductRepo;
			this.VariationRepo = VariationRepo;
			this.ProductItemRepo = ProductItemRepo;
            this.UserManager = UserManager;
		}

		public IActionResult Index(int categoryId)
		{
            return View(ProductRepo.Get(p => p.CategoryId == categoryId));
		}
		public IActionResult Details(int productId)
		{
			
			Product product = ProductRepo.GetById(productId, p => p.Category, p => p.ProductItems,p=>p.Reviews);
			List<Review> review = ReviewRepo.GetAll(p => p.User);
			IEnumerable<Review> reviewsWithUserAndProduct = review.Where(review => review.ProductId == productId);
				List<Variation> variationWithOption =VariationRepo.GetAll(v=>v.VariationOptions);
			IEnumerable<Variation> variationWithOptions = variationWithOption.Where(p => p.CategoryId == product.CategoryId);
            List<ProductItem> productItems = ProductItemRepo.GetAll(p => p.ProductConfigurations);
            var selectedproductItems = productItems.Where(p => p.ProductId == productId);

            ViewData["variationWithOptions"] = variationWithOptions;
            ViewData["reviewsWithUserAndProduct"] = reviewsWithUserAndProduct;

			
			ViewData["selectedproductItems"] = selectedproductItems;
            return View(product);
		}
        [Authorize]
        public async Task<IActionResult> AddReview(int productId,string Comment)
        {
            //string comment = "This is Good";
            ApplicationUser appUser = await UserManager.FindByNameAsync(User.Identity.Name);
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
