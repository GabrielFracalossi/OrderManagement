using OrderManagement.Controllers.Products.Models;

namespace OrderManagement.Controllers.OrderItems.Models
{
    public class OrderItemViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public required ProductsViewModel Product { get; set; }
        public int Quantity { get; set; }
    }

    public class OrderItemRequest
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
