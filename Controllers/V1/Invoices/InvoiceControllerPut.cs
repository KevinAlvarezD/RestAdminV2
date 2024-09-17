using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdminV2.Controllers
{
    public partial class InvoiceController : ControllerBase
    {
        [HttpPut("{id}")]
        [SwaggerOperation(
            Summary = "Updates an existing Invoice by its ID.",
            Description = "This endpoint allows you to update an existing Invoice in the database. If the Invoice with the specified ID does not exist, a 404 (Not Found) status code is returned. If the request data is invalid or does not match the ID, a 400 (Bad Request) status code is returned."
        )]

        [SwaggerResponse(204, "The invoice was updated successfully.")]
        [SwaggerResponse(400, "The invoice ID does not match or the request data is invalid.")]
        [SwaggerResponse(404, "The invoice with the specified ID was not found.")]
        [SwaggerResponse(500, "An internal server error occurred while updating the invoice.")]
        public async Task<IActionResult> UpdateInvoice(int id, Invoice updatedInvoice)
        {
            if (id != updatedInvoice.Id)
            {
                return BadRequest("The invoice ID in the URL does not match the ID in the body.");
            }

            var existingInvoice = await _context.Invoices.FindAsync(id);
            if (existingInvoice == null)
            {
                return NotFound();
            }

            existingInvoice.Number = updatedInvoice.Number;
            existingInvoice.OrderId = updatedInvoice.OrderId;
            existingInvoice.Total = updatedInvoice.Total;
            existingInvoice.DateInvoice = updatedInvoice.DateInvoice;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Invoices.Any(e => e.Id == id))
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
    }
}
