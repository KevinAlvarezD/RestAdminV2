using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;


namespace RestAdminV2.Controllers
{
    public partial class InvoiceController
    {
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