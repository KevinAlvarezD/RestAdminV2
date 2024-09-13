using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers

{
    public partial class ProductController
    {
        [HttpGet("topSellingProduct")]
        public async Task<ActionResult> GetTopSellingProduct()
        {
            var orderProducts = await _context.OrderProducts
                .Include(op => op.Product)
                .ToListAsync();

            var topProduct = orderProducts
                .GroupBy(item => item.ProductId)
                .Select(group => new
                {
                    ProductId = group.Key,
                    TotalSold = group.Sum(item => item.Quantity),
                    TotalEarnings = group.Sum(item => item.Quantity * (item.Product.Price - item.Product.Cost)),
                    Product = group.FirstOrDefault().Product
                })
                .OrderByDescending(result => result.TotalSold)
                .FirstOrDefault();

            if (topProduct == null)
            {
                return NotFound("No sales data found.");
            }

            return Ok(new
            {
                ProductId = topProduct.ProductId,
                ProductName = topProduct.Product.Name,
                TotalSold = topProduct.TotalSold,
                TotalEarnings = topProduct.TotalEarnings
            });
        }
    }
}