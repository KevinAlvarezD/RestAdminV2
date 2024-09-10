using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;
using Microsoft.EntityFrameworkCore;

namespace RestAdminV2.Controllers
{
    public partial class InvoiceController : ControllerBase
    {
        // POST: api/invoice
        [HttpPost]
        public async Task<IActionResult> CreateInvoice([FromBody] Invoice invoice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var Order = await _context.Orders.FindAsync(invoice.OrderId);
                if (Order == null)
                {
                    return NotFound($"Order with ID {invoice.OrderId} not found.");
                }

                invoice.Order = Order;

                byte[] pdfFile = _invoiceService.GenerateInvoicePdf(invoice);

                invoice.PdfFile = pdfFile;

                _context.Invoices.Add(invoice);
                await _context.SaveChangesAsync();

                return File(pdfFile, "application/pdf", "invoice.pdf");
            }
            catch (DbUpdateException dbEx)
            {
                return StatusCode(500, $"Database update error: {dbEx.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}