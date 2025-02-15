using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderManagement.Data;

namespace OrderManagement.Controllers.Reports
{
    public partial class ReportsController(OrderContext context)
    {
        [HttpGet]
        public IActionResult Index()
        {
            var report = context.Orders
                .Include(o => o.Customer)
                .Include(o => o.Items)
                .ThenInclude(i => i.Product)
                .GroupBy(o => new { o.Customer.Id, o.Customer.Name })
                .Select(group => new
                {
                    CustomerId = group.Key.Id,
                    CustomerName = group.Key.Name,
                    TotalSpent = group.Sum(o => o.Items.Sum(i => i.Quantity * i.Product.Price))
                })
                .OrderByDescending(o => o.TotalSpent)
                .ToList();

            return View(report);
        }
    }
}
