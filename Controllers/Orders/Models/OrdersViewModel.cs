using OrderManagement.Controllers.Customers.Models;

namespace OrderManagement.Controllers.Orders.Models
{
    public class OrdersViewModel
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public required CustomersViewModel Customer { get; set; }
        public List<OrderItemViewModel> Items { get; set; } = new List<OrderItemViewModel>();
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
    }
}
