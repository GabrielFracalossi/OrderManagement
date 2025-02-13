using OrderManagement.Controllers.Products.Models;

namespace OrderManagement.Controllers.Orders.Models
{
    public class OrderItemViewModel
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public required ProductsViewModel Product { get; set; }
        public int Quantity { get; set; }
    }
}
