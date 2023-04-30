using ecommerce.Models;
using ecommerce.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ecommerce.Controllers
{
    public class ProductController : Controller
    {
        IRepository<Product> ProductRepo;
        IRepository<Variation> VariationRepo;
        IRepository<ProductItem> ProductItemRepo;
        private UserManager<ApplicationUser> userManager;

        public ProductController(IRepository<Product> ProductRepo,
            IRepository<Variation> VariationRepo,
            IRepository<ProductItem> ProductItemRepo,
            UserManager<ApplicationUser> userManager)
        {
            this.ProductRepo = ProductRepo;
            this.VariationRepo = VariationRepo;
            this.ProductItemRepo = ProductItemRepo;
            this.userManager = userManager;
        }

        public IActionResult Index(int categoryId)
        {
            var x = ProductRepo.GetAll(p => p.ProductItems).Where(p => p.CategoryId == categoryId).ToList();

            return View(x);
        }
        public IActionResult Details(int productId)
        {
            Product product = ProductRepo.GetById(productId, p => p.Category, p => p.ProductItems);
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
            //List<Variation> variations =VariationRepo.GetAll(v=>v.CategoryId==product.CategoryId);
            List<Variation> variationWithOptions = VariationRepo.GetAll(v => v.VariationOptions)
                .Where(variation => variation.CategoryId == product.CategoryId).ToList();
            //ViewData["variations"] = variations;
            ViewData["variationWithOptions"] = variationWithOptions;
            List<ProductItem> productItems = ProductItemRepo.GetAll(p => p.ProductConfigurations);
            var selectedproductItems = productItems.Where(p => p.ProductId == productId);
            ViewData["selectedproductItems"] = selectedproductItems;
            return View(product);
        }
    }
}
