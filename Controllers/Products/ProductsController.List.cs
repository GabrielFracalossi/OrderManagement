using Microsoft.AspNetCore.Mvc;
using OrderManagement.Data;
using OrderManagement.Controllers.Products.Models;

namespace OrderManagement.Controllers.Products
{
    public partial class ProductsController(OrderContext context) : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<ProductsViewModel>> Index()
        {
            var products = context.Products
                .ToList();

            return View(products);
        }
    }
}
