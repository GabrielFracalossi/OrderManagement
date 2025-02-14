using Microsoft.AspNetCore.Mvc;

namespace OrderManagement.Controllers.Products
{
    public partial class ProductsController
    {
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
            return Ok("Produto excluído com sucesso.");
        }
    }
}
