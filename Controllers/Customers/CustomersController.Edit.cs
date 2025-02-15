using Microsoft.AspNetCore.Mvc;
using OrderManagement.Controllers.Customers.Models;

namespace OrderManagement.Controllers.Customers
{
    public partial class CustomersController
    {
        [HttpGet]
        public ActionResult<EditCustomersViewModel> Edit(int id)
        {
            var customer = context.Customers.Find(id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        [HttpPost]
        public IActionResult Edit(int id, EditCustomersViewModel customer)
        {
            var existingcustomer = context.Customers.Find(id);
            if (existingcustomer == null)
            {
                return NotFound();
            }

            existingcustomer.Name = customer.Name;
            existingcustomer.Email = customer.Email;

            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
