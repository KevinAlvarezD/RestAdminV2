using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.DTOs;
using RestAdminV2.Models;


namespace RestAdminV2.Controllers
{
    public partial class OrderController
    {
        // PUT: api/Order/5
        [HttpPut("{id}")]
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

            existingOrder.TablesId = updateOrderDTO.TablesId;
            existingOrder.Observations = updateOrderDTO.Observations;

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
                    Order = existingOrder
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