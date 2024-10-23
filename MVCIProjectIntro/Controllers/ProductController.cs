using Microsoft.AspNetCore.Mvc;
using MVCIProjectIntro.Models;

namespace MVCIProjectIntro.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> list = new List<Product>()
        {
            new Product {Id = 1 ,Name = "Kek",Price = 15},
            new Product {Id = 2 ,Name = "Elma",Price = 150},
            new Product {Id = 3 ,Name = "Limon",Price = 250}
        };
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            return View(list)
;       }
    }
}
