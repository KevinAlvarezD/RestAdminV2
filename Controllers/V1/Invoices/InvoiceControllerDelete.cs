using Microsoft.AspNetCore.Mvc;

namespace RestAdminV2.Controllers
{
    public partial class InvoiceController
    {
        // DELETE: api/invoice/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInvoice(int id)
        {
            var invoice = await _context.Invoices.FindAsync(id);
            if (invoice == null)
            {
                return NotFound();
            }

            _context.Invoices.Remove(invoice);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}