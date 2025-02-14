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
        public ActionResult<IEnumerable<CustomersViewModel>> GetCustomers(int id)
        {
            var customer = context.Customers.Find(id);

            if (customer == null)
            {
                return NotFound();
            }
            return context.Customers.ToList();
        }
    }
}
