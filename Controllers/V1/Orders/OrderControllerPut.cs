using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.DTOs;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestAdminV2.Controllers
{
    public partial class OrderController : ControllerBase
    {
        [HttpPut("{id}")]
        [SwaggerOperation(
    Summary = "Updates an existing order",
    Description = "This endpoint updates an existing order in the database. It requires the ID of the order and the updated data. Returns 204 if the update was successful, or 404 if the order was not found. Returns 400 if any of the products specified in the request are not found."
)]
        [SwaggerResponse(204, "The order was successfully updated.")]
        [SwaggerResponse(400, "If any of the products specified in the request are not found.")]
        [SwaggerResponse(404, "If the order with the specified ID was not found.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
        public async Task<IActionResult> PutOrder(int id, UpdateOrderDTO updateOrderDTO)
        {
            var existingOrder = await _context.Orders
                .Include(o => o.OrderProducts)
                .ThenInclude(op => op.Product)
                .FirstOrDefaultAsync(o => o.Id == id);

            if (existingOrder == null)
            {
                return NotFound();
            }

            if (updateOrderDTO.TablesId == null)
            {
                existingOrder.TablesId = null; 
            }
            else
            {
                var table = await _context.Tables.FindAsync(updateOrderDTO.TablesId);
                if (table == null)
                {
                    return BadRequest("Table not found.");
                }
                existingOrder.TablesId = updateOrderDTO.TablesId;
                existingOrder.Tables = table; 
            }

            existingOrder.Observations = updateOrderDTO.Observations;
            existingOrder.Status = updateOrderDTO.Status;

            _context.OrderProducts.RemoveRange(existingOrder.OrderProducts);

            foreach (var orderProductDTO in updateOrderDTO.OrderProducts)
            {
                var product = await _context.Products.FindAsync(orderProductDTO.ProductId);
                if (product == null)
                {
                    return BadRequest($"Product with ID {orderProductDTO.ProductId} not found.");
                }

                existingOrder.OrderProducts.Add(new OrderProduct
                {
                    ProductId = product.Id,
                    Quantity = orderProductDTO.Quantity,
                    OrderId = id
                });
            }

            _context.Entry(existingOrder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.Id == id);
        }
    }
}