using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.DTOs;
using RestAdminV2.Models;


namespace RestAdmin.Controllers;


public partial class KitchenController
{
    // POST: api/Kitchen/create-from-order/{orderId}
    [HttpPost("create-from-order/{orderId}")]
    public async Task<IActionResult> CreateOrderKitchenFromOrder(int orderId)
    {

        var order = await _context.Orders
            .Include(o => o.OrderProducts)
            .ThenInclude(op => op.Product)
            .FirstOrDefaultAsync(o => o.Id == orderId);

        if (order == null || !order.OrderProducts.Any())
        {
            return NotFound("Order not found or no products associated with this order.");
        }


        var kitchen = new Kitchen
        {
            OrderId = order.Id,
            KitchenItems = order.OrderProducts.Select(op => new KitchenItem
            {
                ProductId = op.Product.Id,
                Quantity = op.Quantity
            }).ToList()
        };

        _context.Kitchens.Add(kitchen);
        await _context.SaveChangesAsync();


        return CreatedAtAction(nameof(GetKitchen), new { id = kitchen.Id }, kitchen);
    }

}
