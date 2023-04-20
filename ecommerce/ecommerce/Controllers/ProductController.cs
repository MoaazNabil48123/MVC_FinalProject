using ecommerce.Models;
using ecommerce.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ecommerce.Controllers
{
	public class ProductController : Controller
	{
		IRepository<Product> ProductRepo;
		public ProductController(IRepository<Product> ProductRepo)
		{
			this.ProductRepo = ProductRepo;
		}

		public IActionResult Index(int categoryId)
		{
			var result = ProductRepo.GetAll(p => p.CategoryId==categoryId).ToList();
				return View(result);
		}
		public IActionResult Details(int productId)
		{
			return View(ProductRepo.GetById(productId));
		}
	}
}
