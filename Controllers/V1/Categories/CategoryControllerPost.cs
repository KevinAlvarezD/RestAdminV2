using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using RestAdminV2.Models;

namespace RestAdmin.Controllers
{
    public partial class CategoriesController : ControllerBase
    {
        [HttpPost]
        [SwaggerOperation(
            Summary = "Creates a new category",
            Description = "Creates a new category in the database. Returns the created category along with its ID."
        )]

        [SwaggerResponse(201, "Returns the created category along with its ID.", typeof(Categories))]
        [SwaggerResponse(400, "If the category data is invalid or missing.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
        
        public async Task<ActionResult<Categories>> PostCategories([FromBody] Categories category)
        {
            if (category == null)
            {
                return BadRequest("Category data is required.");
            }

            _context.Categories.Add(category);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCategories), new { id = category.Id }, category);
        }
    }
}
