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
            
            var invoices = await _context.PreInvoices
            .Where(p => p.DateInvoice.Month == month)
            .ToListAsync();

            if (invoices == null || !invoices.Any())
            {
                return NotFound("the month entered is not valid"); 
            }

            return Ok(invoices);  

        }

    }
}
