using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class OrderDetailsController
    {
        // GET: api/OrderDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDetails>>> GetOrderDetails()
        {
            return await _context.OrderDetails.Include(i => i.Order).ThenInclude(o => o.Kitchen).Include(i => i.Order).ThenInclude(o => o.Tables).Include(i => i.Menu).ToListAsync();
        }

        // GET: api/OrderDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDetails>> GetOrderDetails(int id)
        {
            var orderDetails = await _context.OrderDetails.Include(i => i.Order).Include(i => i.Menu).FirstOrDefaultAsync(i => i.Id == id);
            if (orderDetails == null)
            {
                return NotFound();
            }

            return Ok(orderDetails);
        }
    }
}