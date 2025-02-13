using Microsoft.AspNetCore.Mvc;
using OrderManagement.Data;
using OrderManagement.Controllers.Customers.Models;

namespace OrderManagement.Controllers.Customers
{
    [Route("api/customers")]
    [ApiController]
    public partial class CustomersController(OrderContext context) : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<CustomersViewModel>> GetCustomers()
        {
            return context.Customers.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<CustomersViewModel> GetCustomerById(int id)
        {
            var customer = context.Customers.Find(id);
            if (customer == null)
            {
                return NotFound();
            }
            return customer;
        }

        [HttpPost]
        public ActionResult<CustomersViewModel> CreateCustomer(CustomersViewModel customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();

            return CreatedAtAction(nameof(GetCustomerById), new { id = customer.Id }, customer);
        }
    }
}
