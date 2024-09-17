using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class ClientsController
    {
        // GET: api/Client
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client>>> GetClient()
        {
            return await _context.Clients.ToListAsync();
        }


        /// <summary>
        /// Return a client by its ID.
        /// </summary>

        /// <param name="id">
        /// The id of the client to Return
        /// </param>

        /// <remarks>
        /// This endpoint allows you to fetch a specific client by providing its ID.
        /// If the client does not exist, a 404 (Not Found) status code is returned.
        /// </remarks>

        /// <response code="200">Returns the requested client</response>
        /// <response code="404">If the client with the specified ID is not found</response>
        /// <response code="500">If there was an internal error while fetching the client</response>

        // GET: api/Client/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> GetClient(int id)
        {
            var Client = await _context.Clients.FindAsync(id);
            if (Client == null)
            {
                return NotFound();
            }

            return Client;
        }
    }
}