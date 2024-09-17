using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdminV2.Controllers
{
    public partial class UserController : ControllerBase
    {
        // PUT: api/users/5
        [HttpPut("{id}")]
        [SwaggerOperation(
            Summary = "Update an existing user",
            Description = "Updates the details of an existing user. The user ID must match the ID in the URL."
        )]
        
        [SwaggerResponse(204, "The user was successfully updated.")]
        [SwaggerResponse(400, "If the user ID in the URL does not match the ID in the request body, or if the request data is invalid.")]
        [SwaggerResponse(404, "If the user with the specified ID was not found.")]
        [SwaggerResponse(500, "If there was an internal error while updating the user.")]
        public async Task<IActionResult> PutUser(int id, User User)
        {
            if (id != User.Id)
            {
                return BadRequest("User ID mismatch.");
            }
            
            User.PasswordHash = PasswordHelper.HashPassword(User.PasswordHash);
            _context.Entry(User).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
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

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}
