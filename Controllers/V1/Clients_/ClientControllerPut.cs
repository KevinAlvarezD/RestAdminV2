using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class ClientController
    {
        // PUT: api/Client/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClient(int id, Client Client)
        {
            if (id != Client.Id)
            {
                return BadRequest("Client ID mismatch.");
            }

            _context.Entry(Client).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientExists(id))
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

        private bool ClientExists(int id)
        {
            return _context.Clients.Any(e => e.Id == id);
        }
    }
}