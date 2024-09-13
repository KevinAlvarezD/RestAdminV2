using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class PreInvoiceController
    {
        // DELETE: api/invoice/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePreInvoice(int id)
        {
            var Preinvoice = await _context.PreInvoices.FindAsync(id);
            if (Preinvoice == null)
            {
                return NotFound();
            }

            _context.PreInvoices.Remove(Preinvoice);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}