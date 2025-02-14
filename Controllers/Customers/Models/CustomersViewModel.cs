namespace OrderManagement.Controllers.Customers.Models
{
    public class CustomersViewModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
    }
}
