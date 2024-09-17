using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class InvoiceController
    {
         /// <summary>
        /// Updates an existing Invoice by its ID.
        /// </summary>
        
        /// <remarks>
        /// This endpoint allows you to update an existing Invoice in the database. If the Invoice with the specified ID does not exist, a 404 (Not Found) status code is returned. If the request data is invalid or does not match the ID, a 400 (Bad Request) status code is returned.
        /// </remarks>
        
        /// <param name="id">
        /// The ID of the Invoice to update.
        /// </param>
        
        /// <param name="updatedInvoice">
        /// The Invoice object containing the updated data.
        /// </param>
        
        /// <response code="204">If the Invoice was updated successfully</response>
        /// <response code="400">If the Invoice ID does not match or the request data is invalid</response>
        /// <response code="404">If the Invoice with the specified ID was not found</response>
        /// <response code="500">If there was an internal error while updating the Invoice</response>
        /// 
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
    }
}