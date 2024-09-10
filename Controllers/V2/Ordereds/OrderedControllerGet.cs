using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;


namespace RestAdminV2.Controllers
{
    public partial class OrderedController
    {
        // GET: api/Ordered/TopMenus?month=9
        [HttpGet("TopMenus")]
        public async Task<ActionResult<IEnumerable<Ordered>>> GetTopMenus(int month)
        {
            {
                var topMenus = await _context.OrderDetails
                    .Include(od => od.Menu)
                    .Include(od => od.Ordered)
                        .ThenInclude(o => o.Invoices)
                    .Where(od => od.Ordered.Invoices
                        .Any(i => i.DateInvoice.Month == month)) // Verifica el mes en todas las fechas de las facturas
                    .GroupBy(od => new { od.Menu.Id, od.Menu.Name })
                    .Select(g => new
                    {
                        MenuId = g.Key.Id,
                        MenuName = g.Key.Name,
                        TotalQuantitySold = g.Sum(od => od.Quantity)
                    })
                    .OrderByDescending(g => g.TotalQuantitySold)
                    .ToListAsync();

                if (!topMenus.Any())
                {
                    return NotFound("No Menus found for the specified month.");
                }

                return Ok(topMenus);
            }
        }
    }
}