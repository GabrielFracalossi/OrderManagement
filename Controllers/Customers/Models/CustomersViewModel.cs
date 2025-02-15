namespace OrderManagement.Controllers.Customers.Models
{
    public class CustomersViewModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
    }

    public class CustomersRequest
    {
        public int CustomerId { get; set; }
        public string Email { get; set; }
    }
}
