using Microsoft.AspNetCore.Mvc;
using OrderManagement.Data;
using OrderManagement.Controllers.Products.Models;

namespace OrderManagement.Controllers.Products
{
    [Route("api/products")]
    [ApiController]
    public partial class ProductsController(OrderContext context) : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<ProductsViewModel>> GetProducts()
        {
            return context.Products.ToList();
        }

        [HttpPost]
        public ActionResult<ProductsViewModel> CreateProduct(ProductsViewModel product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return CreatedAtAction(nameof(GetProducts), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, ProductsViewModel product)
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
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            context.Products.Remove(product);
            context.SaveChanges();
            return NoContent();
        }
    }
}
