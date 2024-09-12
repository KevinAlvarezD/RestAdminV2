using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.DTOs;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class PreInvoiceController
    {
        // // POST: api/Menus
        // [HttpPost]
        // public async Task<ActionResult<PreInvoice>> CreatePreinvoice([FromBody] PreInvoice Preinvoice)
        // {
        //     if (!ModelState.IsValid)
        //     {
        //         return BadRequest(ModelState);
        //     }

        //     _context.PreInvoices.Add(Preinvoice);
        //     await _context.SaveChangesAsync();

        //     return CreatedAtAction(nameof(GetPreInvoice), new { id = Preinvoice.Id }, Preinvoice);
        // }


        // POST: api/preinvoice/create-from-order/5
        [HttpPost("create-from-order/{orderId}")]
        public async Task<IActionResult> CreatePreInvoiceFromOrder(int orderId)
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

            // Calculate the total
            var total = orderProducts.Sum(op => op.Product.Price * op.Quantity);

            // Create the new PreInvoice
            var preInvoice = new PreInvoice
            {
                Number = GenerateInvoiceNumber(), // Implement this method to generate invoice number
                OrderId = orderId,
                Total = total,
                DateInvoice = DateTime.Now,
                Observations = "Generated from order"
            };

            _context.PreInvoices.Add(preInvoice);
            await _context.SaveChangesAsync();

            // Return the created PreInvoice with a route to its details
            return CreatedAtAction(nameof(GetPreInvoice), new { id = preInvoice.Id }, preInvoice);
        }

        private int GenerateInvoiceNumber()
        {
            // Implement a logic to generate invoice numbers
            return new Random().Next(1000, 9999); // Example implementation
        }
    }
}