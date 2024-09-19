using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdminV2.Controllers
{
    public partial class PreInvoiceController : ControllerBase
    {
        [HttpGet]
        [SwaggerOperation(
            Summary = "Returns a list of all pre-invoices",
            Description = "This endpoint returns a list of all pre-invoices available in the database."
        )]
        [SwaggerResponse(200, "Returns the list of pre-invoices.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
        public async Task<ActionResult<IEnumerable<PreInvoice>>> GetPreInvoices()
        {
            var preInvoices = await _context.PreInvoices.ToListAsync();
            return Ok(preInvoices);
        }

        // GET: api/preinvoice/5
        [HttpGet("{id}")]
        [SwaggerOperation(
            Summary = "Returns a pre-invoice by ID",
            Description = "This endpoint returns a specific pre-invoice by its ID. Returns 404 if the pre-invoice does not exist."
        )]

        [SwaggerResponse(200, "Returns the requested pre-invoice.")]
        [SwaggerResponse(404, "If the pre-invoice with the specified ID is not found.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
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
