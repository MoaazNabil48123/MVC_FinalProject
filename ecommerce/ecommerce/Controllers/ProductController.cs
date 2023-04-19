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
		public IActionResult Index(int id)
		{

			return View();
		}
		public IActionResult Details(int id)
		{
			return View();
		}
	}
}
