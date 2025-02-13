﻿namespace OrderManagement.Controllers.Products.Models
{
    public class ProductsViewModel
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
