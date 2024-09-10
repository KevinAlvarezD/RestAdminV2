using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class PreInvoiceController
    {
        // POST: api/Menus
        [HttpPost]
        public async Task<ActionResult<Product>> CreatePreinvoice([FromBody] PreInvoice Preinvoice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PreInvoices.Add(Preinvoice);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPreInvoice), new { id = Preinvoice.Id }, Preinvoice);
        }
    }
}