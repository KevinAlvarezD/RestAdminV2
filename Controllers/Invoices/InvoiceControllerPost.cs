using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;

namespace RestAdmin.Controllers
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
                var ordered = await _context.Ordereds.FindAsync(invoice.IdOrder);
                if (ordered == null)
                {
                    return NotFound($"Order with ID {invoice.IdOrder} not found.");
                }

                invoice.Ordered = ordered;

                byte[] pdfFile = _invoiceService.GenerateInvoicePdf(invoice);

                invoice.PdfFile = pdfFile;

                _context.Invoices.Add(invoice);
                await _context.SaveChangesAsync();

                return File(pdfFile, "application/pdf", "invoice.pdf");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}