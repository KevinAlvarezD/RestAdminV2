using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;


namespace RestAdminV2.Controllers
{
    public partial class OrderedController
    {
        // GET: api/Customer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ordered>>> GetOrdereds()
        {
            return await _context.Ordereds.Include(i => i.Customer).Include(i => i.Tables).ToListAsync();
        }

        // GET: api/Ordered/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ordered>> GetOrdered(int id)
        {
            var ordered = await _context.Ordereds.Include(i => i.Customer).Include(i => i.Tables).FirstOrDefaultAsync(i => i.Id == id);
            if (ordered == null)
            {
                return NotFound();
            }

            return Ok(ordered);
        }
    }
}