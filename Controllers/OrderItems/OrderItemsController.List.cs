using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderManagement.Controllers.OrderItems.Models;
using OrderManagement.Data;

namespace OrderManagement.Controllers.Orders
{
    [Route("api/orderitems")]
    [ApiController]
    public partial class OrderItemsController(OrderContext context) : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<OrderItemViewModel>> GetOrderItems()
        {
            return context.OrderItems.Include(oi => oi.Product).ToList();
        }
    }
}
