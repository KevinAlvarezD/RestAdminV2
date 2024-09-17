using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading.Tasks;

namespace RestAdminV2.Controllers
{
    public partial class PreInvoiceController : ControllerBase
    {
        [HttpDelete("{id}")]
        [SwaggerOperation(
            Summary = "Deletes a pre-invoice by ID",
            Description = "This endpoint deletes a specific pre-invoice from the database by its ID. Returns 404 if the pre-invoice does not exist."
        )]

        [SwaggerResponse(204, "The pre-invoice was successfully deleted.")]
        [SwaggerResponse(404, "If the pre-invoice with the specified ID is not found.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
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
