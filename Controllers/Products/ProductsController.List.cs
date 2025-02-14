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
    }
}
