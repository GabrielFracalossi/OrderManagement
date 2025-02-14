using Microsoft.AspNetCore.Mvc;
using OrderManagement.Controllers.Products.Models;

namespace OrderManagement.Controllers.Products
{
    public partial class ProductsController
    {
        [HttpPost]
        public ActionResult<ProductsViewModel> CreateProduct(ProductsViewModel product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return CreatedAtAction(nameof(GetProducts), new { id = product.Id }, product);
        }
    }
}
