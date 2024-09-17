using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RestAdminV2.Controllers
{
    public partial class ProductController
    {
        [HttpGet("salesByHour")]
        public async Task<ActionResult> GetSalesByHour()
        {
            var sales = await _context.Invoices
                .ToListAsync();

            var salesByHour = sales
                .GroupBy(s => s.DateInvoice.Hour)
                .Select(g => new
                {
                    Hour = g.Key,
                    TotalInvoices = g.Sum(s => s.Total )
                })
                .OrderBy(h => h.Hour)
                .ToList();

            if (salesByHour.Count == 0)
            {
                return NotFound("No sales data found.");
            }

            return Ok(salesByHour);
        }
    }
}