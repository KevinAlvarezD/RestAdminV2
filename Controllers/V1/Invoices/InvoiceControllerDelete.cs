using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdminV2.Controllers
{
    public partial class InvoiceController : ControllerBase
    {
        [HttpDelete("{id}")]
        [SwaggerOperation(
            Summary = "Deletes an invoice specified by its ID",
            Description = "This endpoint allows you to delete an invoice from the database. If the invoice does not exist, a 404 (Not Found) status code is returned."
        )]
        [SwaggerResponse(204, "The invoice was deleted successfully.")]
        [SwaggerResponse(404, "The invoice with the specified ID was not found.")]
        [SwaggerResponse(500, "An internal server error occurred while deleting the invoice.")]
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
