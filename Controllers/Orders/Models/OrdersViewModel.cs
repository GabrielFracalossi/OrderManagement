using OrderManagement.Controllers.Customers.Models;
using OrderManagement.Controllers.OrderItems.Models;
using OrderManagement.Controllers.Products.Models;

namespace OrderManagement.Controllers.Orders.Models
{
    public class OrdersViewModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public required CustomersViewModel Customer { get; set; }
        public List<OrderItemViewModel> Items { get; set; }
        public DateOnly OrderDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public List<ProductsViewModel> Products { get; set; }
        public List<CustomersViewModel> Customers { get; set; }
    }

    public class OrderCreateRequest
    {
        public int CustomerId { get; set; }
        public required List<OrderItemRequest> Items { get; set; } = new List<OrderItemRequest>();
    }
}
