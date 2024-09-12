using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.DTOs;
using RestAdminV2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAdminV2.Controllers
{

    public partial class OrderController : ControllerBase
    {
        [HttpGet("Orders")]
        public async Task<ActionResult<IEnumerable<OrderDTO>>> GetOrders()
        {
            var orders = await _context.Orders
                .Include(o => o.Tables)
                .Include(o => o.OrderProducts)
                .ThenInclude(op => op.Product.Category)
                .ToListAsync();

            var orderDTOs = orders.Select(o => new OrderDTO
            {
                Id = o.Id,
                Observations = o.Observations,
                TablesId = o.TablesId,
                TableName = o.Tables.Name,
                Products = o.OrderProducts.Select(op => new ProductDTO
                {
                    Id = op.Product.Id,
                    Name = op.Product.Name,
                    Price = op.Product.Price,
                    Quantity = op.Quantity,
                    ImageURL = op.Product.ImageURL,
                    Category = op.Product.Category
                }).ToList()
            }).ToList();

            return Ok(orderDTOs);
        }

        [HttpGet("OrderProducts")]
        public async Task<ActionResult<OrderDTO>> GetOrder(int id)
        {
            var order = await _context.Orders
                .Include(o => o.Tables)
                .Include(o => o.OrderProducts)
                    .ThenInclude(op => op.Product)
                        .ThenInclude(p => p.Category)
                .FirstOrDefaultAsync(o => o.Id == id);

            if (order == null)
            {
                return NotFound();
            }
            var orderDTO = new OrderDTO
            {
                Id = order.Id,
                Observations = order.Observations,
                TablesId = order.TablesId,
                TableName = order.Tables.Name,
                Products = order.OrderProducts.Select(op => new ProductDTO
                {
                    Id = op.Product.Id,
                    Name = op.Product.Name,
                    Price = op.Product.Price,
                    Quantity = op.Quantity,
                    ImageURL = op.Product.ImageURL,
                    Category = op.Product.Category

                }).ToList()
            };

            return Ok(orderDTO);
        }

    }
}
