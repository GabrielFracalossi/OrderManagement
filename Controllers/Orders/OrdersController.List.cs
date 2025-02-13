using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderManagement.Data;
using OrderManagement.Controllers.Orders.Models;
namespace OrderManagement.Controllers.Orders
{
    [Route("api/orders")]
    [ApiController]
    public partial class OrdersController(OrderContext context) : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<OrdersViewModel>> GetOrders()
        {
            return context.Orders.Include(o => o.Customer).Include(o => o.Items).ThenInclude(i => i.Product).ToList();
        }

        [HttpPost]
        public ActionResult<OrdersViewModel> CreateOrder(OrdersViewModel order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
            return CreatedAtAction(nameof(GetOrders), new { id = order.Id }, order);
        }
    }
}
