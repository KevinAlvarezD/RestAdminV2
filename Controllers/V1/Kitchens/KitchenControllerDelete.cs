using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.DTOs;
using RestAdminV2.Models;


namespace RestAdmin.Controllers;


public partial class KitchenController
{
    // DELETE: api/Kitchen/5
    [HttpDelete("{id}")]
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
