using Microsoft.AspNetCore.Mvc;

namespace OrderManagement.Controllers.OrderItems
{
    public partial class OrderItemsController
    {
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
