using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class TablesController
    {
        // GET: api/Tables
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tables>>> GetTables()
        {
            var Tables = await _context.Tables.ToListAsync();
            return Ok(Tables);
        }

        // GET: api/Menus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tables>> GetTables(int id)
        {
            var Tables = await _context.Tables.FindAsync(id);

            if (Tables == null)
            {
                return NotFound();
            }

            return Ok(Tables);
        }
    }
}