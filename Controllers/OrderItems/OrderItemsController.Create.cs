using Microsoft.AspNetCore.Mvc;
using OrderManagement.Controllers.OrderItems.Models;
using OrderManagement.Data;

namespace OrderManagement.Controllers.OrderItems
{
    public partial class OrderItemsController(OrderContext context) : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<OrderItemViewModel>> Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult<OrderItemViewModel> Create(OrderItemViewModel orderItem)
        {
            var product = context.Products.Find(orderItem.ProductId);
            if (product == null || product.Stock < orderItem.Quantity)
            {
                return BadRequest("Produto não disponível em estoque.");
            }

            product.Stock -= orderItem.Quantity;
            context.OrderItems.Add(orderItem);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public ActionResult<OrderItemViewModel> GetOrderItemsById(int id)
        {
            var orderItem = context.OrderItems.Find(id);
            if (orderItem == null)
            {
                return NotFound();
            }

            return orderItem;
        }
    }
}
