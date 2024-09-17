using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;


namespace RestAdminV2.Controllers
{
    public partial class InvoiceController
    {
         /// <summary>
        /// Creates a new Invoice.
        /// </summary>
         
        /// <remarks>
        /// This endpoint allows you to create a new Invoice in the database. The created Invoice will be returned in the response.
        /// </remarks>
         
        /// <param name="orderId">
        /// The Invoice object to be created.
        /// </param>

        /// <response code="201">Returns the created Invoice along with its ID</response>
        /// <response code="400">If the Invoice data is invalid or missing</response>
        /// <response code="500">If there was an internal error while creating the Invoice</response>
        // POST: api/invoice/create-from-order/{orderId}
        [HttpPost("create-from-order/{orderId}")]
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