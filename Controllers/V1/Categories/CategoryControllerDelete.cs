using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdmin.Controllers
{
    public partial class CategoriesController : ControllerBase
    {
        [HttpDelete("{id}")]
        [SwaggerOperation(
            Summary = "Deletes a category by ID",
            Description = "Deletes a specific category from the database by its ID. Returns 404 if the category does not exist."
        )]

        [SwaggerResponse(204, "The category was successfully deleted.")]
        [SwaggerResponse(404, "If the category with the specified ID is not found.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
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
