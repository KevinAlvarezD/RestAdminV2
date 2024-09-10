using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;
namespace RestAdmin.Controllers
{
    public partial class KitchenController
    {
        // GET: api/Kitchen
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Kitchen>>> GetKitchen()
        {
            return await _context.Kitchens.ToListAsync();
        }

        //Get: api/Kitchen
        [HttpGet("{id}")]
        public async Task<ActionResult<Kitchen>> GetKitchen(int id)
        {
            var Kitchen = await _context.Kitchens.FindAsync(id);
            if (Kitchen == null)
            {
                return NotFound();
            }
            return Kitchen;
        }
       
    }
}

