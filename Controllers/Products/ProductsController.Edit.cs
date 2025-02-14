using Microsoft.AspNetCore.Mvc;
using OrderManagement.Controllers.Products.Models;

namespace OrderManagement.Controllers.Products
{
    public partial class ProductsController
    {
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, EditProductsViewModel product)
        {
            var existingProduct = context.Products.Find(id);
            if (existingProduct == null)
            {
                return NotFound();
            }

            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            existingProduct.Stock = product.Stock;

            context.SaveChanges();
            return Ok("Produto atualizado com sucesso.");
        }
    }
}
