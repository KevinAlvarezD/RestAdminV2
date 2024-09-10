using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class MenuController
    {
        // GET: api/Menus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Menu>>> GetMenus()
        {
            var Menus = await _context.Menus.Include(m => m.InvoiceID).Include(m => m.KitchenId).Include(m => m.OrderID).Include(m => m.PreInvoiceID).ToListAsync();
            return Ok(Menus);
        }

        // GET: api/Menus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Menu>> GetMenu(int id)
        {
            var Menu = await _context.Menus.Include(m => m.InvoiceID).Include(m => m.KitchenId).Include(m => m.OrderID).Include(m => m.PreInvoiceID).FirstOrDefaultAsync(m => m.Id == id);

            if (Menu == null)
            {
                return NotFound();
            }

            return Ok(Menu);
        }
    }
}