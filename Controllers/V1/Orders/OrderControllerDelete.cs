using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class OrderController : ControllerBase
    {
        [HttpDelete("{id}")]
        [SwaggerOperation(
            Summary = "Deletes an order by ID",
            Description = "Deletes a specific order from the database by its ID. Returns 404 if the order does not exist."
        )]
        
        [SwaggerResponse(204, "The order was successfully deleted.")]
        [SwaggerResponse(404, "If the order with the specified ID is not found.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
