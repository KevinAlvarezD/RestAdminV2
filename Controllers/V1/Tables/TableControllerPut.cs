using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class TablesController
    {
        // PUT: api/products/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTables(int id, [FromBody] Tables Tables)
        {
            if (id != Tables.Id)
            {
                return BadRequest("Tables ID mismatch.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Entry(Tables).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TablesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool TablesExists(int id)
        {
            return _context.Tables.Any(e => e.Id == id);
        }
    }
}