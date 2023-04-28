using ecommerce.Models;
using ecommerce.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
	public class ProductController : Controller
	{
		IRepository<Product> ProductRepo;
		IRepository<Variation> VariationRepo;
		IRepository<ProductItem> ProductItemRepo;
		public ProductController(IRepository<Product> ProductRepo, IRepository<Variation> VariationRepo, IRepository<ProductItem> ProductItemRepo)
		{
			this.ProductRepo = ProductRepo;
			this.VariationRepo = VariationRepo;
			this.ProductItemRepo = ProductItemRepo;
		}

		public IActionResult Index(int categoryId)
		{
            return View(ProductRepo.GetAll(p => p.CategoryId == categoryId));
		}
		public IActionResult Details(int productId)
		{
			Product product = ProductRepo.GetById(productId, p => p.Category, p => p.ProductItems);

			//List<Variation> variations =VariationRepo.GetAll(v=>v.CategoryId==product.CategoryId);
			List<Variation> variationWithOptions =VariationRepo.GetAll(v=>v.VariationOptions);

			//ViewData["variations"] = variations;
			ViewData["variationWithOptions"] = variationWithOptions;

			List<ProductItem> productItems =ProductItemRepo.GetAll(p=>p.ProductConfigurations);
			var selectedproductItems =productItems.Where(p=>p.ProductId== productId);
			ViewData["selectedproductItems"] = selectedproductItems;
            return View(product);
		}
	}
}
