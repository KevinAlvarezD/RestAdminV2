using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class PreInvoiceController
    {
        [HttpPut("{id}")]
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