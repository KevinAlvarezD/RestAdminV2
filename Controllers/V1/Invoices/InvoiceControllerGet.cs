using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class InvoiceController
    {
        /// <summary>
        /// Return a list of all Invoice.
        /// </summary>

        /// <remarks>
        /// This endpoint returns a list of all Invoice available in the database.
        /// </remarks>

        /// <response code="200">Returns the list of Invoice</response>
        /// <response code="500">If there was an internal error while fetching the Invoice</response>
        // GET: api/invoice
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Invoice>>> GetInvoices()
        {
            return Ok(await _context.Invoices.ToListAsync());
        }

        // GET: api/invoice/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Invoice>> GetInvoice(int id)
        {
            var invoice = await _context.Invoices.FindAsync(id);

            if (invoice == null)
            {
                return NotFound();
            }

            return Ok(invoice);
        }

    }
}