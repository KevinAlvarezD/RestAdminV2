using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.DTOs;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAdminV2.Controllers
{
    public partial class OrderController : ControllerBase
    {
        [HttpGet]
        [SwaggerOperation(
            Summary = "Returns a list of all orders",
            Description = "This endpoint returns a list of all orders available in the database."
        )]
        [SwaggerResponse(200, "Returns the list of orders.", typeof(IEnumerable<OrderDTO>))]
        [SwaggerResponse(500, "An internal server error occurred.")]
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
                Status = o.Status,
                Observations = o.Observations,
                TablesId = o.TablesId, 
                TableName = o.TablesId.HasValue ? o.Tables.Name : null,
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

        [HttpGet("{id}")]
        [SwaggerOperation(
            Summary = "Retrieves a specific order by ID",
            Description = "This endpoint returns a specific order from the database by its ID."
        )]
        [SwaggerResponse(200, "Returns the order with the specified ID.", typeof(OrderDTO))]
        [SwaggerResponse(404, "If the order with the specified ID is not found.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
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
                Status = order.Status,
                Observations = order.Observations,
                TablesId = order.TablesId,
                TableName = order.TablesId.HasValue ? order.Tables.Name : null, 
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

