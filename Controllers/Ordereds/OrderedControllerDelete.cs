using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;

namespace RestAdmin.Controllers
{
    public partial class OrderedController
    {
        // DELETE: api/Ordered/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrdered(int id)
        {
            var ordered = await _context.Ordereds.FindAsync(id);
            if (ordered == null)
            {
                return NotFound();
            }

            _context.Ordereds.Remove(ordered);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}