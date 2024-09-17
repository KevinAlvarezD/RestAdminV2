using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;
using RestAdminV2.Models;

namespace RestAdmin.Controllers
{
    public partial class CategoriesController : ControllerBase
    {
        [HttpPut("{id}")]
        [SwaggerOperation(
            Summary = "Updates an existing category by its ID",
            Description = "Updates an existing category in the database. If the category with the specified ID does not exist, a 404 (Not Found) status code is returned. If the request data is invalid or does not match the ID, a 400 (Bad Request) status code is returned."
        )]

        [SwaggerResponse(204, "If the category was updated successfully.")]
        [SwaggerResponse(400, "If the category ID does not match or the request data is invalid.")]
        [SwaggerResponse(404, "If the category with the specified ID was not found.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
        
        public async Task<IActionResult> PutCategories(int id, [FromBody] Categories category)
        {
            if (id != category.Id)
            {
                return BadRequest("Category ID mismatch.");
            }

            _context.Entry(category).State = EntityState.Modified;

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

