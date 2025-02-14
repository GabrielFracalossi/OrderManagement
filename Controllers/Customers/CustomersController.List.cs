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
    }
}
