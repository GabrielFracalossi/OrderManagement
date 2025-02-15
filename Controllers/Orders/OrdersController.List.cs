using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderManagement.Data;
using OrderManagement.Controllers.Orders.Models;
namespace OrderManagement.Controllers.Orders
{
    public partial class OrdersController(OrderContext context) : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<OrdersViewModel>> Index()
        {
            var orders = context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Items)
                .ThenInclude(i => i.Product)
                .ToList();
         
            return View(orders);
        }
    }
}
