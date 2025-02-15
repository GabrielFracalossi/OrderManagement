using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderManagement.Controllers.OrderItems.Models;
using OrderManagement.Data;

namespace OrderManagement.Controllers.Orders
{
    public partial class OrderItemsController(OrderContext context) : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<OrderItemViewModel>> Index()
        {
            var orderItems = context.OrderItems
                .Include(oi => oi.Product)
                .ToList();

            return View(orderItems);
        }
    }
}
