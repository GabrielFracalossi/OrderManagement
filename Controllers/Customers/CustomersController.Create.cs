using Microsoft.AspNetCore.Mvc;
using OrderManagement.Controllers.Customers.Models;

namespace OrderManagement.Controllers.Customers
{
    public partial class CustomersController
    {
        [HttpGet]
        public ActionResult<IEnumerable<CustomersViewModel>> Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult<CustomersViewModel> Create(CustomersViewModel customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
