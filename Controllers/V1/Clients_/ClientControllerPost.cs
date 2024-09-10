using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;


namespace RestAdminV2.Controllers
{
    public partial class ClientController 
    {
        // POST: api/Client
        [HttpPost]
        public async Task<ActionResult<Client>> PostClient(Client Client)
        {
            _context.Clients.Add(Client);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetClient), new { id = Client.Id }, Client);
        }
    }
}