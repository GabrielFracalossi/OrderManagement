using Microsoft.AspNetCore.Mvc;
using OrderManagement.Data;
using OrderManagement.Controllers.Customers.Models;

namespace OrderManagement.Controllers.Customers
{
    public partial class CustomersController(OrderContext context) : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<CustomersViewModel>> Index()
        {
            var customers = context.Customers
                .ToList();

            return View(customers);
        }
    }
}
