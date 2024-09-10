using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;


namespace RestAdminV2.Controllers
{
    public partial class OrderController
    {
        // GET: api/Kitchen
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            return await _context.Orders.ToListAsync();
        }

        // GET: api/Order/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var Order = await _context.Orders.FirstOrDefaultAsync(i => i.Id == id);
            if (Order == null)
            {
                return NotFound();
            }

            return Ok(Order);
        }
    }
}