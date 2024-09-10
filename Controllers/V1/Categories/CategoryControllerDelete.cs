using Microsoft.AspNetCore.Mvc;

namespace RestAdmin.Controllers
{
    public partial class CategoriesController{
        //Delete: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategories(int id)
        {
            var Categories = await _context.Categories.FindAsync(id);
            if (Categories == null)
            {
                return NotFound();
            }
            _context.Categories.Remove(Categories);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}