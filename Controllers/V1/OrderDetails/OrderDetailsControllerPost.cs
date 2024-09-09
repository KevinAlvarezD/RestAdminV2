using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;


namespace RestAdminV2.Controllers
{
    public partial class OrderDetailsController
    {
        // POST: api/OrderDetails
        [HttpPost]
        public async Task<ActionResult<OrderDetails>> PostOrderDetails(OrderDetails orderDetails)
        {
            _context.OrderDetails.Add(orderDetails);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetOrderDetails), new { id = orderDetails.Id }, orderDetails);
        }
    }
}