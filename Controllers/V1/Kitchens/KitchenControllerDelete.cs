using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.DTOs;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;


namespace RestAdmin.Controllers;


public partial class KitchenController
{
    // DELETE: api/Kitchen/5
    [HttpDelete("{id}")]
    [SwaggerOperation(
            Summary = "Delete a kitchen by ID",
            Description = "Deletes a specific kitchen and its associated items by ID."
        )]

    [SwaggerResponse(204, "The kitchen was successfully deleted.")]
    [SwaggerResponse(404, "If the kitchen with the specified ID is not found.")]
    [SwaggerResponse(500, "If an error occurs while deleting the kitchen.")]
    
    public async Task<IActionResult> DeleteKitchen(int id)
    {
        var kitchen = await _context.Kitchens
            .Include(k => k.KitchenItems)
            .FirstOrDefaultAsync(k => k.Id == id);

        if (kitchen == null)
        {
            return NotFound();
        }

        if (kitchen.KitchenItems != null)
        {
            _context.KitchenItems.RemoveRange(kitchen.KitchenItems);
        }

        _context.Kitchens.Remove(kitchen);
        await _context.SaveChangesAsync();

        return NoContent();
    }


}
