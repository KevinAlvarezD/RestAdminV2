using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class ClientsController : ControllerBase
    {
        [HttpPost]
        [SwaggerOperation(
            Summary = "Creates a new client",
            Description = "This endpoint allows you to create a new client in the database. The created client will be returned in the response."
        )]
        [SwaggerResponse(201, "Returns the created client along with its ID", typeof(Client))]
        [SwaggerResponse(400, "If the client data is invalid or missing.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
        public async Task<ActionResult<Client>> PostClient([FromBody] Client client)
        {
            if (client == null)
            {
                return BadRequest("Client data is required.");
            }

            _context.Clients.Add(client);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetClient), new { id = client.Id }, client);
        }
    }
}
