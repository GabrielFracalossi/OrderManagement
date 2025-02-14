using System.ComponentModel.DataAnnotations;

namespace OrderManagement.Controllers.Products.Models
{
    public class EditProductsViewModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        [Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
