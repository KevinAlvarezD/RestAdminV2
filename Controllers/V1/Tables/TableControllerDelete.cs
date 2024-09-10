using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class TablesController
    {
        // DELETE: api/Tables/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTables(int id)
        {
            var Tables = await _context.Tables.FindAsync(id);
            if (Tables == null)
            {
                return NotFound();
            }

            _context.Tables.Remove(Tables);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}