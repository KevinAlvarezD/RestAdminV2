using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;


namespace RestAdminV2.Controllers
{
    public partial class ClientsController
    {

        /// <summary>
        /// Creates a new client.
        /// </summary>

        /// <remarks>
        /// This endpoint allows you to create a new client in the database. The created client will be returned in the response.
        /// </remarks>

        /// <param name="Client">
        /// The client object to be created.
        /// </param>

        /// <response code="201">Returns the created client along with its ID</response>
        /// <response code="400">If the client data is invalid or missing</response>
        /// <response code="500">If there was an internal error while creating the client</response>
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