using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.DTOs;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdminV2.Controllers
{
    public partial class PreInvoiceController : ControllerBase
    {
        // POST: api/preinvoice/create-from-order/5
        [HttpPost("create-from-order")]
        [SwaggerOperation(
            Summary = "Creates a pre-invoice from an existing order",
            Description = "This endpoint generates a pre-invoice based on the provided order ID. Calculates the total from the associated order products and creates a new pre-invoice entry in the database. Returns 404 if the order or associated products are not found."
        )]
        [SwaggerResponse(201, "The pre-invoice was successfully created.")]
        [SwaggerResponse(404, "If the order with the specified ID is not found or there are no products associated with the order.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
        public async Task<IActionResult> CreatePreInvoiceFromOrder(int orderId)
        {

            var orderProducts = await _context.OrderProducts
                .Include(op => op.Product)
                .Where(op => op.OrderId == orderId)
                .ToListAsync();

            if (orderProducts == null || !orderProducts.Any())
            {
                return NotFound("Order not found or no products associated with this order.");
            }

            // Calculate the total
            var total = orderProducts.Sum(op => op.Product.Price * op.Quantity);

            var preInvoice = new PreInvoice
            {
                Number = GenerateInvoiceNumber(),
                OrderId = orderId,
                Total = total,
                DateInvoice = DateTime.Now,
                Observations = "Generated from order"
            };

            _context.PreInvoices.Add(preInvoice);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPreInvoice), new { id = preInvoice.Id }, preInvoice);
        }

        private int GenerateInvoiceNumber()
        {
            return new Random().Next(1000, 9999);
        }
    }
}
