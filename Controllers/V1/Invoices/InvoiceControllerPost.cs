using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdminV2.Controllers
{
    public partial class InvoiceController : ControllerBase
    {
        [HttpPost("create-from-order")]
        [SwaggerOperation(
            Summary = "Creates a new invoice from an order",
            Description = "This endpoint allows you to create a new invoice in the database from an existing order. The created invoice will be returned in the response."
        )]

        [SwaggerResponse(201, "Returns the created invoice along with its ID.")]
        [SwaggerResponse(400, "The invoice data is invalid or missing.")]
        [SwaggerResponse(404, "The order was not found or no products are associated with the order.")]
        [SwaggerResponse(500, "An internal server error occurred while creating the invoice.")]
        public async Task<IActionResult> CreateInvoiceFromOrder(int orderId)
        {
            // Get the order and its products
            var orderProducts = await _context.OrderProducts
                .Include(op => op.Product)
                .Where(op => op.OrderId == orderId)
                .ToListAsync();

            if (orderProducts == null || !orderProducts.Any())
            {
                return NotFound("Order not found or no products associated with this order.");
            }

            var total = orderProducts.Sum(op => op.Product.Price * op.Quantity);

            var invoice = new Invoice
            {
                Number = GenerateInvoiceNumber(),
                OrderId = orderId,
                Total = total,
                Observations = "Generated from order",
                DateInvoice = DateTime.Now
            };

            _context.Invoices.Add(invoice);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetInvoice), new { id = invoice.Id }, invoice);
        }

        private int GenerateInvoiceNumber()
        {
            return new Random().Next(1000, 9999);
        }
    }
}
