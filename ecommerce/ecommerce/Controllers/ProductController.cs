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

		public IActionResult Index(int CategoryId)
		{

            return View(ProductRepo.GetAll().Where(p => p.CategoryId == CategoryId).ToList());
		}
		public IActionResult Details(int ProductId)
		{
			return View(ProductRepo.GetById(ProductId));
		}
	}
}
