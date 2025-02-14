using Microsoft.AspNetCore.Mvc;
using OrderManagement.Controllers.Orders.Models;

namespace OrderManagement.Controllers.Orders
{
    public partial class OrdersController
    {
        [HttpPost]
        public ActionResult<OrdersViewModel> CreateOrder(OrdersViewModel order)
        {
            context.Orders.Add(order);
            context.SaveChanges();
            return CreatedAtAction(nameof(GetOrders), new { id = order.Id }, order);
        }
    }
}
