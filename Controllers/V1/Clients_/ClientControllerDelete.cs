using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class ClientController
    {
        // DELETE: api/Client/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            var Client = await _context.Clients.FindAsync(id);
            if (Client == null)
            {
                return NotFound();
            }

            _context.Clients.Remove(Client);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}