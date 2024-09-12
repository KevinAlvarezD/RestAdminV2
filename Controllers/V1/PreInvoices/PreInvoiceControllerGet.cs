using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class PreInvoiceController
    {
        // // GET: api/invoice
        // [HttpGet]
        // public async Task<ActionResult<IEnumerable<PreInvoice>>> GetPreInvoices()
        // {
        //     var Preinvoices = await _context.PreInvoices.ToListAsync();
        //     return Ok(Preinvoices);
        // }

        // // GET: api/invoice/5
        // [HttpGet("{id}")]
        // public async Task<ActionResult<PreInvoice>> GetPreInvoice(int id)
        // {
        //     var Preinvoice = await _context.PreInvoices.FirstOrDefaultAsync(i => i.Id == id);

        //     if (Preinvoice == null)
        //     {
        //         return NotFound();
        //     }

        //     return Ok(Preinvoice);
        // }

        // GET: api/preinvoice
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PreInvoice>>> GetPreInvoices()
        {
            var preInvoices = await _context.PreInvoices.ToListAsync();
            return Ok(preInvoices);
        }

        // GET: api/preinvoice/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PreInvoice>> GetPreInvoice(int id)
        {
            var preInvoice = await _context.PreInvoices.FindAsync(id);

            if (preInvoice == null)
            {
                return NotFound();
            }

            return Ok(preInvoice);
        }
    }
}