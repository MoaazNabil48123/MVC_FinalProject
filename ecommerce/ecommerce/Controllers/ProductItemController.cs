using ecommerce.Models;
using ecommerce.Repository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ecommerce.Controllers
{
    public class ProductItemController : Controller
    {
        IRepository<ProductItem> ProductItemRepo;
        public ProductItemController(IRepository<ProductItem> ProductItemRepo)
        {
         
            this.ProductItemRepo = ProductItemRepo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetProductItem(int productId,List<int> variationOptions)
        {
            List<ProductItem> productItems =ProductItemRepo.GetAll(p=>p.ProductConfigurations);
            var selectedproductItems =productItems.Where(p=>p.ProductId== productId);
            foreach (var item in selectedproductItems)
            {
                List<int> test=new List<int>();
               
                foreach (var x in item.ProductConfigurations)
                {
                    test.Add(x.VariationOptionsId);
                }
                bool flag = true;
                int i = 0;
                 while (flag && i< variationOptions.Count)
                {
                    if (!test.Contains(variationOptions[i]))
                    {
                        flag = false;
                    }
                    i++;
                }
                 if(flag) {
                    List<float> x = new List<float>() { item.Price, item.StockQty };
                    return Json(x); }
            }
            return Json(0);
        }
    }
}
