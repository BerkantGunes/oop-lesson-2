using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Project_OOP.Data;
using Project_OOP.Entity;

namespace Project_OOP.Controllers
{
    public class CustomerController : Controller
    {
        Context context = new Context();
        public IActionResult Index() // listeleme işlemi için
        {

            var values = context.Customers.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCustomer() // ekleme işlemi
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer c)
        {
            if (c.CustomerName.Length>=6 && c.CustomerCity!= "" && c.CustomerCity.Length >= 3)
            {
                context.Add(c);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.message = "Missing Infos. Please Check!";
                return View();
            }
        }
        public IActionResult DeleteCustomer(int id) // Silme işlemi için
        {
            var value = context.Customers.Where(x=>x.CustomerId == id).FirstOrDefault(); //aldik
            context.Remove(value); // sildik
            context.SaveChanges(); // kaydettik
            return RedirectToAction("Index"); // yönlendirdik
        }
        [HttpGet]
        public IActionResult UpdateCustomer(int id) // güncelleme işlemi için alma kısmı
        {
            var value = context.Customers.Where(x => x.CustomerId == id).FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer c) // güncellemenin yapıldığı kısım 
        {
            var value = context.Customers.Where(x=>x.CustomerId==c.CustomerId).FirstOrDefault();
            value.CustomerCity = c.CustomerCity;
            value.CustomerName = c.CustomerName;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
