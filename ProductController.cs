using Microsoft.AspNetCore.Mvc;
using Project_OOP.Data;

namespace Project_OOP.Controllers
{
    public class ProductController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Products.ToList(); // context üzerinden products icinde yer alan degerleri listeledik. ToList metotu ile.
            return View(values); // atadıgımız  degiskeni burada döndürdük ki bunları view tarafında karşılayabilmek için.
        }
    }
}
