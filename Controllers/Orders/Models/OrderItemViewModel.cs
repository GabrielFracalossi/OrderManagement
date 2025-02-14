using OrderManagement.Controllers.Products.Models;

namespace OrderManagement.Controllers.Orders.Models
{
    public class OrderItemViewModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public required ProductsViewModel Product { get; set; }
        public int Quantity { get; set; }
    }
}
