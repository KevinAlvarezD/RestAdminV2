using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdmin.Controllers
{
    public partial class TableController
    {
        // GET: api/Table
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Table>>> GetTables()
        {
            var tables = await _context.Tables.ToListAsync();
            return Ok(tables);
        }

        // GET: api/products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Table>> GetTable(int id)
        {
            var table = await _context.Tables.FindAsync(id);

            if (table == null)
            {
                return NotFound();
            }

            return Ok(table);
        }
    }
}