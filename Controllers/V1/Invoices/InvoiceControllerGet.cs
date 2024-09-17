using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdminV2.Controllers
{
    public partial class InvoiceController : ControllerBase
    {
        [HttpGet]
        [SwaggerOperation(
            Summary = "Return a list of all invoices",
            Description = "This endpoint returns a list of all invoices available in the database."
        )]
        [SwaggerResponse(200, "Returns the list of invoices.")]
        [SwaggerResponse(500, "An internal server error occurred while fetching the invoices.")]
        public async Task<ActionResult<IEnumerable<Invoice>>> GetInvoices()
        {
            return Ok(await _context.Invoices.ToListAsync());
        }

        [HttpGet("{id}")]
        [SwaggerOperation(
            Summary = "Return an invoice by its ID",
            Description = "This endpoint allows you to fetch a specific invoice by providing its ID. If the invoice does not exist, a 404 (Not Found) status code is returned."
        )]

        [SwaggerResponse(200, "Returns the requested invoice.")]
        [SwaggerResponse(404, "The invoice with the specified ID was not found.")]
        [SwaggerResponse(500, "An internal server error occurred while fetching the invoice.")]
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
