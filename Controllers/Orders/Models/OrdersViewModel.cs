using OrderManagement.Controllers.Customers.Models;
using OrderManagement.Controllers.OrderItems.Models;

namespace OrderManagement.Controllers.Orders.Models
{
    public class OrdersViewModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public required CustomersViewModel Customer { get; set; }
        public List<OrderItemViewModel> Items { get; set; } = new List<OrderItemViewModel>();
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
    }

    public class OrderCreateRequest
    {
        public int CustomerId { get; set; }
        public List<OrderItemRequest> Items { get; set; }
    }
}
