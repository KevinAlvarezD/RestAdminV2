using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdmin.Controllers
{
   public partial class CategoriesController
    {
        // PUT: api/Categories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategories(int id, Categories Categories)
        {
            if (id != Categories.Id)
            {
                return BadRequest("Categories ID mismatch.");
            }

            _context.Entry(Categories).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoriesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool CategoriesExists(int id)
        {
            return _context.Categories.Any(item => item.Id == id);
        }
    }
}