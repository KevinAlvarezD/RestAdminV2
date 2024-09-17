using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdminV2.Controllers
{
    public partial class PreInvoiceController : ControllerBase
    {
        [HttpPut("{id}")]
        [SwaggerOperation(
            Summary = "Updates an existing pre-invoice",
            Description = "This endpoint updates the details of a pre-invoice identified by its ID. Returns 400 if the ID in the URL does not match the ID in the request body, 404 if the pre-invoice is not found, or 500 if an internal server error occurs."
        )]
        [SwaggerResponse(204, "The pre-invoice was successfully updated.")]
        [SwaggerResponse(400, "The invoice ID in the URL does not match the ID in the body.")]
        [SwaggerResponse(404, "If the pre-invoice with the specified ID is not found.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
        public async Task<IActionResult> UpdatePreInvoice(int id, PreInvoice updatedPreInvoice)
        {
            if (id != updatedPreInvoice.Id)
            {
                return BadRequest("The invoice ID in the URL does not match the ID in the body.");
            }

            var existingPreInvoice = await _context.PreInvoices.FindAsync(id);
            if (existingPreInvoice == null)
            {
                return NotFound("PreInvoice not found.");
            }

            existingPreInvoice.Number = updatedPreInvoice.Number;
            existingPreInvoice.OrderId = updatedPreInvoice.OrderId;
            existingPreInvoice.Observations = updatedPreInvoice.Observations;
            existingPreInvoice.Total = updatedPreInvoice.Total;
            existingPreInvoice.DateInvoice = updatedPreInvoice.DateInvoice;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PreInvoiceExists(id))
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

        private bool PreInvoiceExists(int id)
        {
            return _context.PreInvoices.Any(e => e.Id == id);
        }
    }
}