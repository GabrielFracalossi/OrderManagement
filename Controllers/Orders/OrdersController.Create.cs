using Microsoft.AspNetCore.Mvc;
using OrderManagement.Controllers.OrderItems.Models;
using OrderManagement.Controllers.Orders.Models;

namespace OrderManagement.Controllers.Orders
{
    public partial class OrdersController
    {
        [HttpGet]
        public ActionResult<IEnumerable<OrdersViewModel>> Create()
        {
            var products = context.Products.ToList();
            var customers = context.Customers.ToList();

            ViewBag.Products = products;
            ViewBag.Customers = customers;

            return View();
        }

        [HttpPost]
        public ActionResult<OrdersViewModel> Create([FromForm] OrderCreateRequest request)
        {
            var customer = context.Customers.Find(request.CustomerId);

            if (customer == null)
            {
                return BadRequest("Cliente não encontrado.");
            }

            var orderItems = new List<OrderItemViewModel>();

            foreach (var item in request.Items)
            {
                var product = context.Products.Find(item.ProductId);

                if (product == null || product.Stock == 0 || product.Stock < item.Quantity)
                {
                    return BadRequest("Produto não disponível em estoque.");
                }

                if (item.Quantity > 0)
                {
                    product.Stock -= item.Quantity;
                    orderItems.Add(new OrderItemViewModel
                    {
                        ProductId = product.Id,
                        Product = product,
                        Quantity = item.Quantity
                    });
                }
            }

            var order = new OrdersViewModel
            {
                CustomerId = customer.Id,
                Customer = customer,
                Items = orderItems,
            };

            context.Orders.Add(order);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
