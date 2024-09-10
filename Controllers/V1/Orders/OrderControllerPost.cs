using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;


namespace RestAdminV2.Controllers
{
    public partial class OrderController
    {
        // POST: api/Order
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order Order)
        {
            _context.Orders.Add(Order);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOrder), new { id = Order.Id }, Order);
        }
    }
}