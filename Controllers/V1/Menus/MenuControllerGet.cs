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
            var Menus = await _context.Menus.ToListAsync();
            return Ok(Menus);
        }

        // GET: api/Menus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Menu>> GetMenu(int id)
        {
            var Menu = await _context.Menus.FindAsync(id);

            if (Menu == null)
            {
                return NotFound();
            }

            return Ok(Menu);
        }
    }
}