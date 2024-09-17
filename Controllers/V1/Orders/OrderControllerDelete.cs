using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class OrderController
    {
        /// <summary>
        /// Deletes a Order specified by its ID.
        /// </summary>

        /// <remarks>
        /// This endpoint allows you to delete a Order from the database. If the Order does not exist, a 404 (Not Found) status code is returned.
        /// </remarks>

        // DELETE: api/Order/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var Order = await _context.Orders.FindAsync(id);
            if (Order == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(Order);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}