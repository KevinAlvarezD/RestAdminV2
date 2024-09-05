using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;


namespace RestAdmin.Controllers
{
     public partial class CategoryController
    {
        // POST: api/Category
        [HttpPost]
        public async Task<ActionResult<Category>> PostCategory(Category category)
        {
            _context.Categorys.Add(category);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCategory), new { id = category.Id }, category);
        }
    }
}