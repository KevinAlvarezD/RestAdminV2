using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdminV2.Controllers
{
    public partial class UserController : ControllerBase
    {
        // DELETE: api/users/5
        [HttpDelete("{id}")]
        [SwaggerOperation(
            Summary = "Delete a user",
            Description = "Deletes a user from the database based on the provided ID."
        )]
        [SwaggerResponse(204, "The user was deleted successfully.")]
        [SwaggerResponse(404, "If the user with the specified ID is not found.")]
        [SwaggerResponse(500, "If there was an internal error while deleting the user.")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
