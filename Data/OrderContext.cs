using Microsoft.EntityFrameworkCore;
using OrderManagement.Controllers.Customers.Models;
using OrderManagement.Controllers.Products.Models;
using OrderManagement.Controllers.Orders.Models;
using OrderManagement.Controllers.OrderItems.Models;

namespace OrderManagement.Data
{
    public class OrderContext(DbContextOptions<OrderContext> options) : DbContext(options)
    {
        public DbSet<ProductsViewModel> Products { get; set; }
        public DbSet<CustomersViewModel> Customers { get; set; }
        public DbSet<OrdersViewModel> Orders { get; set; }
        public DbSet<OrderItemViewModel> OrderItems { get; set; }
    }
}