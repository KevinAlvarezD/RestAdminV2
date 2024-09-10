using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class MenuController
    {
        // DELETE: api/Menus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenu(int id)
        {
            var Menu = await _context.Menus.FindAsync(id);
            if (Menu == null)
            {
                return NotFound();
            }

            _context.Menus.Remove(Menu);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}