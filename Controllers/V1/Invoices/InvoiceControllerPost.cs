using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;


namespace RestAdminV2.Controllers
{
    public partial class InvoiceController
    {
        // POST: api/Kitchen
        [HttpPost]
        public async Task<ActionResult<Invoice>> PostInvoice(Invoice Invoice)
        {
            _context.Invoices.Add(Invoice);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetInvoice), new { id = Invoice.Id }, Invoice);
        }
    }
}