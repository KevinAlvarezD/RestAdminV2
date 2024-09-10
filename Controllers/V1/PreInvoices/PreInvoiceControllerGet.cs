using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class PreInvoiceController
    {
        // GET: api/invoice
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PreInvoice>>> GetPreInvoices()
        {
            var Preinvoices = await _context.PreInvoices.Include(i => i.Ordered).ThenInclude(o => o.Customer).Include(i => i.Ordered).ThenInclude(o => o.Tables).ToListAsync();
            return Ok(Preinvoices);
        }

        // GET: api/invoice/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PreInvoice>> GetPreInvoice(int id)
        {
            var Preinvoice = await _context.PreInvoices
                .Include(i => i.Ordered)
                .FirstOrDefaultAsync(i => i.Id == id);

            if (Preinvoice == null)
            {
                return NotFound();
            }

            return Ok(Preinvoice);
        }
    }
}    