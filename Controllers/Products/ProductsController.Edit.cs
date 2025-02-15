using Microsoft.AspNetCore.Mvc;
using OrderManagement.Controllers.Products.Models;

namespace OrderManagement.Controllers.Products
{
    public partial class ProductsController
    {
        [HttpGet]
        public ActionResult<EditProductsViewModel> Edit(int id)
        {
            var product = context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(int id, EditProductsViewModel product)
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
            return RedirectToAction(nameof(Index));
        }
    }
}
