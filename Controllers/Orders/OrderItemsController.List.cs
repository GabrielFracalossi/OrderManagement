using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderManagement.Data;
using OrderManagement.Controllers.Orders.Models;

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

        [HttpPost]
        public ActionResult<OrderItemViewModel> CreateOrderItem(OrderItemViewModel orderItem)
        {
            var product = context.Products.Find(orderItem.ProductId);
            if (product == null || product.Stock < orderItem.Quantity)
            {
                return BadRequest("Produto não disponível em estoque.");
            }

            product.Stock -= orderItem.Quantity;
            context.OrderItems.Add(orderItem);
            context.SaveChanges();

            return CreatedAtAction(nameof(GetOrderItems), new { id = orderItem.Id }, orderItem);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrderItem(int id)
        {
            var orderItem = context.OrderItems.Find(id);
            if (orderItem == null)
            {
                return NotFound();
            }

            context.OrderItems.Remove(orderItem);
            context.SaveChanges();
            return NoContent();
        }
    }
}
