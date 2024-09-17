using Microsoft.AspNetCore.Mvc;
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
        [HttpPost]
        [SwaggerOperation(
            Summary = "Creates a new order",
            Description = "This endpoint creates a new order in the database. It requires a valid table ID and product IDs to be provided. Returns 201 if the order was successfully created, or 400 if any of the provided IDs are invalid."
        )]
        [SwaggerResponse(201, "The order was successfully created.", typeof(OrderDTO))]
        [SwaggerResponse(400, "If the table or any of the products specified in the request are not found.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
        public async Task<ActionResult<OrderDTO>> PostOrder(CreateOrderDTO createOrderDTO)
        {
            var table = await _context.Tables.FindAsync(createOrderDTO.TablesId);
            if (table == null)
            {
                return BadRequest("Table not found.");
            }

            var order = new Order
            {
                TablesId = createOrderDTO.TablesId,
                Observations = createOrderDTO.Observations,
                Tables = table,
                OrderProducts = new List<OrderProduct>()
            };

            foreach (var orderProductDTO in createOrderDTO.OrderProducts)
            {
                var product = await _context.Products.FindAsync(orderProductDTO.ProductId);
                if (product == null)
                {
                    return BadRequest($"Product with ID {orderProductDTO.ProductId} not found.");
                }

                order.OrderProducts.Add(new OrderProduct
                {
                    ProductId = product.Id,
                    Quantity = orderProductDTO.Quantity,
                    Order = order
                });
            }

            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            var orderDTO = new OrderDTO
            {
                Id = order.Id,
                Observations = order.Observations,
                TablesId = order.TablesId,
                TableName = table.Name,
                Products = order.OrderProducts.Select(op => new ProductDTO
                {
                    Id = op.Product.Id,
                    Name = op.Product.Name,
                    Price = op.Product.Price,
                    ImageURL = op.Product.ImageURL,
                    Category = op.Product.Category
                }).ToList()
            };

            return CreatedAtAction(nameof(GetOrder), new { id = order.Id }, orderDTO);
        }
    }
}
