using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;

namespace RestAdmin.Controllers
{
    public partial class InvoiceController
    {
        // POST: api/invoice
        [HttpPost]
        public async Task<ActionResult<Invoice>> CreateInvoice([FromBody] Invoice invoice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Invoices.Add(invoice);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetInvoice), new { id = invoice.IdInvoice }, invoice);
        }
    }
}