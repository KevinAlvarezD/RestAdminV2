using Microsoft.AspNetCore.Mvc;
using RestAdmin.Models;
using RestAdminV2.Models;

namespace RestAdmin.Controllers
{
    public partial class OrderedController
    {
        // POST: api/Ordered
        [HttpPost]
        public async Task<ActionResult<Ordered>> PostOrdered(Ordered ordered)
        {
            _context.Ordereds.Add(ordered);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOrdered), new { id = ordered.Id }, ordered);
        }
    }
}