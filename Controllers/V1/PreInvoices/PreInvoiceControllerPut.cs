using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class PreInvoiceController
    {
        // PUT: api/invoice/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePreInvoice(int id, [FromBody] PreInvoice Preinvoice)
        {
            if (id != Preinvoice.Id)
            {
                return BadRequest("Invoice ID mismatch.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Entry(Preinvoice).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvoiceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool InvoiceExists(int id)
        {
            return _context.Invoices.Any(e => e.Id == id);
        }
    }
}