using Microsoft.AspNetCore.Mvc;

namespace RestAdminV2.Controllers.Category
{
    public partial class CategoryController{
        //Delete: api/Category/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = await _context.Categorys.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            _context.Categorys.Remove(category);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}