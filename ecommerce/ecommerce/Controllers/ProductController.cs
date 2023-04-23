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
            return View(ProductRepo.GetAll(p => p.CategoryId == categoryId));
		}
		public IActionResult Details(int productId)
		{
			return View(ProductRepo.GetById(productId));
		}
	}
}
