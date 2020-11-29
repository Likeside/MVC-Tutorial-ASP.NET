using Microsoft.AspNetCore.Mvc;
using MVC_Tutorial.Models;

namespace MVC_Tutorial.Controllers
{
    public class ProductController: Controller
    {
        //AllProducts _allProducts = new AllProducts();
        Product product = new Product(AllProducts.allProducts)
        {
            Title = "Beer",
            Price = (decimal)89.90
        };
        public IActionResult Details()
        {
           
            return View(product);

        }

        public IActionResult List()
        {
            return Content("Product List");
        }
    }
}