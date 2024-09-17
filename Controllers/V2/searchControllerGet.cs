using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers

{
    public partial class ProductController
    {

        [HttpGet("salesByMonth")]
        public async Task<ActionResult<IEnumerable<Invoice>>> SearchByMonth(int month)
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
