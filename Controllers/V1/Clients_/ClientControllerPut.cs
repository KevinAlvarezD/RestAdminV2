using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class ClientsController : ControllerBase
    {
        [HttpPut("{id}")]
        [SwaggerOperation(
            Summary = "Updates an existing client by its ID",
            Description = "Updates an existing client in the database. If the client with the specified ID does not exist, a 404 (Not Found) status code is returned. If the request data is invalid or does not match the ID, a 400 (Bad Request) status code is returned."
        )]
        
        [SwaggerResponse(204, "If the client was updated successfully.")]
        [SwaggerResponse(400, "If the client ID does not match or the request data is invalid.")]
        [SwaggerResponse(404, "If the client with the specified ID was not found.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
        public async Task<IActionResult> PutClient(int id, [FromBody] Client client)
        {
            if (id != client.Id)
            {
                return BadRequest("Client ID mismatch.");
            }

            _context.Entry(client).State = EntityState.Modified;

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
