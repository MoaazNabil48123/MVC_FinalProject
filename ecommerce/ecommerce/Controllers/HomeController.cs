using ecommerce.Context;
using ecommerce.Models;
using ecommerce.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ecommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
		private readonly IRepository<Category> categoryRepo;
		private readonly AppDbContext context;

		public HomeController(ILogger<HomeController> logger,IRepository<Category> categoryRepo, AppDbContext context)
        {
            _logger = logger;
            this.categoryRepo = categoryRepo;
            this.context = context;
		}
        public IActionResult Index()
        {
			return View(categoryRepo.GetAll(c=>c.Products));
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

    }
}