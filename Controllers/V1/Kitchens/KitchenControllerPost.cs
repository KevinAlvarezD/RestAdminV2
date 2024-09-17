using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.DTOs;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;


namespace RestAdmin.Controllers;


public partial class KitchenController
{
    // POST: api/Kitchen/create-from-order/{orderId}
    [HttpPost("create-from-order/{orderId}")]
    [SwaggerOperation(
            Summary = "Create a kitchen from an order",
            Description = "Creates a new kitchen entry based on the specified order, including the associated kitchen items."
        )]
    [SwaggerResponse(201, "The kitchen was successfully created.", typeof(Kitchen))]
    [SwaggerResponse(404, "If the order with the specified ID is not found or has no associated products.")]
    [SwaggerResponse(500, "If an error occurs while creating the kitchen.")]
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
