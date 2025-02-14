using Microsoft.AspNetCore.Mvc;
using OrderManagement.Controllers.Customers.Models;

namespace OrderManagement.Controllers.Customers
{
    public partial class CustomersController
    {
        [HttpPost]
        public ActionResult<CustomersViewModel> CreateCustomer(CustomersViewModel customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();

            return CreatedAtAction(nameof(GetCustomers), new { id = customer.Id }, customer);
        }
    }
}
