using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class ClientsController
    {
        /// <summary>
        /// Deletes a Client specified by its ID.
        /// </summary>

        /// <remarks>
        /// This endpoint allows you to delete a client from the database. If the client does not exist, a 404 (Not Found) status code is returned.
        /// </remarks>

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