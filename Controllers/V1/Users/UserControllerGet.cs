using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdminV2.Controllers
{
    public partial class UserController : ControllerBase
    {
        // GET: api/users
        [HttpGet]
        [SwaggerOperation(
            Summary = "Return all users",
            Description = "Gets a list of all users from the database, including their associated roles."
        )]
        
        [SwaggerResponse(200, "A list of users with their roles.")]
        [SwaggerResponse(500, "If there was an internal error while retrieving the users.")]
        public async Task<ActionResult<IEnumerable<User>>> GetUser()
        {
            var users = await _context.Users.Include(u => u.Role).ToListAsync();
            return Ok(users);
        }

        // GET: api/users/5
        [HttpGet("{id}")]
        [SwaggerOperation(
            Summary = "Return a specific user",
            Description = "Gets a user by their ID, including their associated role."
        )]

        [SwaggerResponse(200, "The user with the specified ID, including their role.")]
        [SwaggerResponse(404, "If the user with the specified ID is not found.")]
        [SwaggerResponse(500, "If there was an internal error while retrieving the user.")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await _context.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }
    }
}
