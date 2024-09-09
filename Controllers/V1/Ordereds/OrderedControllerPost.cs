using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;


namespace RestAdminV2.Controllers
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