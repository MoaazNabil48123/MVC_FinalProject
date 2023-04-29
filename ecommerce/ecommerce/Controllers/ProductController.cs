using ecommerce.Models;
using ecommerce.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

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
			return View(ProductRepo.GetAll(p => p.ProductItems).Where(p => p.CategoryId == categoryId).ToList());
        }
        public IActionResult Details(int productId)
		{
			return View(ProductRepo.GetById(productId));
		}
	}
}
