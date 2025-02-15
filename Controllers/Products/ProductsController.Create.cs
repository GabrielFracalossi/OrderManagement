using Microsoft.AspNetCore.Mvc;
using OrderManagement.Controllers.Products.Models;

namespace OrderManagement.Controllers.Products
{
    public partial class ProductsController
    {
        [HttpGet]
        public ActionResult<IEnumerable<ProductsViewModel>> Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult<ProductsViewModel> Create(ProductsViewModel product)
        {
            context.Products.Add(product);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
