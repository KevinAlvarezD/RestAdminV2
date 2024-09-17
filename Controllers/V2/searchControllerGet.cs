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
        public async Task<ActionResult<IEnumerable<Invoice>>> SearchByMonth([FromQuery] int month)
        {
            if (month < 1 || month > 12)
            {
                return BadRequest("Invalid month.");
            }

            var invoices = await _context.Invoices
            .Where(p => p.DateInvoice.Month == month)
            .ToListAsync();

            if (invoices == null || !invoices.Any())
            {
                return NotFound("No invoices have been recorded this month yet.");
            }

            return Ok(invoices);

        }


        // GET: api/invoices/salesByDay?day=15&month=9&year=2024
        [HttpGet("salesByDay")]
        public async Task<ActionResult<IEnumerable<Invoice>>> SearchByDay(int day, int month, int year)
        {
          
            if (day < 1 || day > 31 || month < 1 || month > 12 || year < 2000 || year > DateTime.Now.Year)
            {
                return BadRequest("Invalid date parameters.");
            }

            var invoices = await _context.Invoices
                .Where(p => p.DateInvoice.Day == day
                            && p.DateInvoice.Month == month
                            && p.DateInvoice.Year == year)
                .ToListAsync();

            if (invoices == null || !invoices.Any())
            {
                return NotFound("No invoices have been recorded on this day.");
            }

            return Ok(invoices);
        }

    }
}
