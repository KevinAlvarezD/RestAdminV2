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
            return await _context.OrderDetails.Include(i => i.Ordered).ThenInclude(o => o.Customer).Include(i => i.Ordered).ThenInclude(o => o.Tables).Include(i => i.Product).ToListAsync();
        }

        // GET: api/OrderDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDetails>> GetOrderDetails(int id)
        {
            var orderDetails = await _context.OrderDetails.Include(i => i.Ordered).Include(i => i.Product).FirstOrDefaultAsync(i => i.Id == id);
            if (orderDetails == null)
            {
                return NotFound();
            }

            return Ok(orderDetails);
        }
    }
}