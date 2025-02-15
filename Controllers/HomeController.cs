using Microsoft.AspNetCore.Mvc;

namespace OrderManagement.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
