using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class InvoiceController
    {
        // PUT: api/invoice/5
        [HttpPut("{id}")]
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

            // Update the existing Invoice with the new values
            existingInvoice.Number = updatedInvoice.Number;
            existingInvoice.OrderId = updatedInvoice.OrderId;
            existingInvoice.Total = updatedInvoice.Total;
            existingInvoice.DateInvoice = updatedInvoice.DateInvoice;

            try
            {
                // Save changes to the database
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

            return NoContent(); // Return 204 No Content on successful update
        }
    }
}