using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdmin.Models;
using RestAdminV2.Models;

namespace RestAdmin.Controllers
{
    public partial class OrderedController
    {
        // PUT: api/Ordered/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrdered(int id, Ordered ordered)
        {
            if (id != ordered.Id)
            {
                return BadRequest("Ordered ID mismatch.");
            }

            _context.Entry(ordered).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderedExists(id))
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

        private bool OrderedExists(int id)
        {
            return _context.Ordereds.Any(e => e.Id == id);
        }
    }
}