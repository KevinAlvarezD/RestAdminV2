using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdminV2.Controllers
{
    public partial class ProductController : ControllerBase
    {
        // GET: api/products/topSellingProduct
        [HttpGet("topSellingProduct")]
        [SwaggerOperation(
            Summary = "Get top selling product",
            Description = "Retrieves the top selling product based on total quantity sold and total earnings."
        )]
        
        [SwaggerResponse(200, "Returns the top selling product along with total quantity sold and total earnings.")]
        [SwaggerResponse(404, "If no sales data is found.")]
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
