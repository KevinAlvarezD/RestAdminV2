using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdmin.Models;
using RestAdminV2.Models;

namespace RestAdmin.Controllers
{
    public partial class OrderedController
    {
        // GET: api/Customer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ordered>>> GetOrdereds()
        {
            return await _context.Ordereds.ToListAsync();
        }

        // GET: api/Ordered/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ordered>> GetOrdered(int id)
        {
            var ordered = await _context.Ordereds.FindAsync(id);
            if (ordered == null)
            {
                return NotFound();
            }

            return ordered;
        }
    }
}