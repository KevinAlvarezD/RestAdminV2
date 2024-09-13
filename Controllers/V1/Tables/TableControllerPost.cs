using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class TablesController
    {
        // POST: api/Tables
        [HttpPost]
        public async Task<ActionResult<Tables>> CreateTables([FromBody] Tables Tables)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Tables.Add(Tables);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTables), new { id = Tables.Id }, Tables);
        }
    }
}