using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;


namespace RestAdmin.Controllers
{
     public partial class CategoriesController
    {
        // POST: api/Categories
        [HttpPost]
        public async Task<ActionResult<Categories>> PostCategories(Categories Categories)
        {
            _context.Categories.Add(Categories);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCategories), new { id = Categories.Id }, Categories);
        }
    }
}