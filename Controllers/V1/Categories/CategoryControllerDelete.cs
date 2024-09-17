using Microsoft.AspNetCore.Mvc;

namespace RestAdmin.Controllers
{
    public partial class CategoriesController
    {
        /// <summary>
        /// Deletes a category specified by its ID.
        /// </summary>
        
        /// <remarks>
        /// This endpoint allows you to delete a category from the database. If the category does not exist, a 404 (Not Found) status code is returned.
        /// </remarks>
        
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