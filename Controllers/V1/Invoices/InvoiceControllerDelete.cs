using Microsoft.AspNetCore.Mvc;

namespace RestAdminV2.Controllers
{
    public partial class InvoiceController
    {

        /// <summary>
        /// Deletes a Invoice specified by its ID.
        /// </summary>

        /// <remarks>
        /// This endpoint allows you to delete a Invoice from the database. If the Invoice does not exist, a 404 (Not Found) status code is returned.
        /// </remarks>

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

        private bool InvoiceExists(int id)
        {
            return _context.Invoices.Any(e => e.Id == id);
        }
    }
}