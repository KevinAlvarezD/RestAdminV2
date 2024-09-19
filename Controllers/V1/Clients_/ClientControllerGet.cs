using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class ClientsController : ControllerBase
    {
        [HttpGet]
        [SwaggerOperation(
            Summary = "Retrieves all clients",
            Description = "This endpoint returns a list of all clients available in the database."
        )]
        
        [SwaggerResponse(200, "Returns a list of clients", typeof(IEnumerable<Client>))]
        [SwaggerResponse(500, "An internal server error occurred.")]

        public async Task<ActionResult<IEnumerable<Client>>> GetClient()
        {
            var clients = await _context.Clients.ToListAsync();
            return Ok(clients);
        }

        [HttpGet("{id}")]
        [SwaggerOperation(
            Summary = "Returns a client by ID",
            Description = "This endpoint allows you to fetch a specific client by providing its ID. If the client does not exist, a 404 (Not Found) status code is returned."
        )]

        [SwaggerResponse(200, "Returns the requested client", typeof(Client))]
        [SwaggerResponse(404, "If the client with the specified ID is not found.")]
        [SwaggerResponse(500, "An internal server error occurred.")]

        public async Task<ActionResult<Client>> GetClient(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            if (client == null)
            {
                return NotFound();
            }

            return Ok(client);
        }
    }
}
