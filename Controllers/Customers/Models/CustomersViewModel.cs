namespace OrderManagement.Controllers.Customers.Models
{
    public class CustomersViewModel
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
    }
}
