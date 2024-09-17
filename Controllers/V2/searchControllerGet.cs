using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdminV2.Controllers
{
    public partial class ProductController : ControllerBase
    {
        // GET: api/products/salesByMonth?month=5
        [HttpGet("salesByMonth")]
        [SwaggerOperation(
            Summary = "Get invoices by month",
            Description = "Retrieves all pre-invoices for a specific month. The month should be between 1 and 12."
        )]
        
        [SwaggerResponse(200, "Returns a list of pre-invoices for the specified month.")]
        [SwaggerResponse(400, "If the provided month is not between 1 and 12.")]
        [SwaggerResponse(404, "If no invoices are found for the specified month.")]
        public async Task<ActionResult<IEnumerable<PreInvoice>>> SearchByMonth([FromQuery] int month)
        {
            if (month < 1 || month > 12)
            {
                return BadRequest("Invalid month.");
            }

            var invoices = await _context.PreInvoices
                .Where(p => p.DateInvoice.Month == month)
                .ToListAsync();

            if (invoices == null || !invoices.Any())
            {
                return NotFound("No invoices found for the specified month.");
            }

            return Ok(invoices);
        }
    }
}
