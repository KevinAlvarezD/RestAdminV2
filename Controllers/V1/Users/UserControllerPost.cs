using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;


namespace RestAdminV2.Controllers
{
    public partial class UsersController
    {
        // POST: api/Users
        [HttpPost]
        public async Task<ActionResult<Users>> PostUsers(Users Users)
        {
            _context.Users.Add(Users);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUsers), new { id = Users.Id }, Users);
        }
    }
}