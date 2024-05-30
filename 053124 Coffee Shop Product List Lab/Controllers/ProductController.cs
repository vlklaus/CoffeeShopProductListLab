using _053124_Coffee_Shop_Product_List_Lab.Models;
using Microsoft.AspNetCore.Mvc;

namespace _053124_Coffee_Shop_Product_List_Lab.Controllers
{
    public class ProductController : Controller
    {
        ProductDbContext dbContext = new ProductDbContext();
        [HttpGet]
        public IActionResult Index()
        {
            List<Product> result = dbContext.Products.ToList();
            return View(result);
        }

        public IActionResult Details(int id)
        {
            Product result = dbContext.Products.FirstOrDefault(p => p.Id == id);
            return View(result);
        }




    }
}
