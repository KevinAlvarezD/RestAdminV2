using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdminV2.Controllers
{
    public partial class UserController : ControllerBase
    {
        // POST: api/users
        [HttpPost]
        [SwaggerOperation(
            Summary = "Create a new user",
            Description = "Adds a new user to the database. The password will be hashed before saving."
        )]
        
        [SwaggerResponse(201, "The user was successfully created.")]
        [SwaggerResponse(400, "If the provided user data is invalid or if there was an issue with the request.")]
        [SwaggerResponse(500, "If there was an internal error while creating the user.")]
        public async Task<ActionResult<User>> PostUser(User user)
        {
            // Encript the password
            user.PasswordHash = PasswordHelper.HashPassword(user.PasswordHash);

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }
    }
}
