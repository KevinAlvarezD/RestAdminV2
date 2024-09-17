using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdminV2.Controllers
{
    public partial class ClientsController : ControllerBase
    {
        [HttpDelete("{id}")]
        [SwaggerOperation(
            Summary = "Deletes a client by ID",
            Description = "This endpoint allows you to delete a client from the database. If the client does not exist, a 404 (Not Found) status code is returned."
        )]
        [SwaggerResponse(204, "The client was successfully deleted.")]
        [SwaggerResponse(404, "If the client with the specified ID is not found.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            var client = await _context.Clients.FindAsync(id);
            if (client == null)
            {
                return NotFound();
            }

            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
