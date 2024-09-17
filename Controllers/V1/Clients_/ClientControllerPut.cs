using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class ClientsController
    {
        /// <summary>
        /// Updates an existing Client by its ID.
        /// </summary>

        /// <remarks>
        /// This endpoint allows you to update an existing Client in the database. If the Client with the specified ID does not exist, a 404 (Not Found) status code is returned. If the request data is invalid or does not match the ID, a 400 (Bad Request) status code is returned.
        /// </remarks>

        /// <param name="id">
        /// The ID of the Client to update.
        /// </param>

        /// <param name="Client">
        /// The Client object containing the updated data.
        /// </param>

        /// <response code="204">If the Client was updated successfully</response>
        /// <response code="400">If the Client ID does not match or the request data is invalid</response>
        /// <response code="404">If the Client with the specified ID was not found</response>
        /// <response code="500">If there was an internal error while updating the Client</response>
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