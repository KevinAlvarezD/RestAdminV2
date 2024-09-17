using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class ProductController : ControllerBase
    {
        [HttpGet("allSellingProducts")]
        public async Task<ActionResult> GetAllSellingProducts()
        {
            var orderProducts = await _context.OrderProducts
                .Include(op => op.Product)
                .ToListAsync();

            var products = orderProducts
                .GroupBy(item => item.ProductId)
                .Select(group => new
                {
                    ProductId = group.Key,
                    Product = group.FirstOrDefault().Product,
                    TotalSold = group.Sum(item => item.Quantity),
                    TotalEarnings = group.Sum(item => item.Quantity * (item.Product.Price - item.Product.Cost))
                })
                .OrderByDescending(result => result.TotalSold)
                .ToList();

            if (products.Count == 0)
            {
                return NotFound("No sales data found.");
            }

            return Ok(products.Select(product => new
            {
                ProductId = product.ProductId,
                ProductName = product.Product.Name,
                TotalSold = product.TotalSold,
                TotalEarnings = product.TotalEarnings
            }));
        }
    }
}
