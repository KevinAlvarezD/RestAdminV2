using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;

namespace RestAdmin.Controllers
{
    public partial class CategoriesController
    {
        /// <summary>
        /// Creates a new category.
        /// </summary>
         
        /// <remarks>
        /// This endpoint allows you to create a new category in the database. The created category will be returned in the response.
        /// </remarks>
         
        /// <param name="category">
        /// The category object to be created.
        /// </param>

        /// <response code="201">Returns the created category along with its ID</response>
        /// <response code="400">If the category data is invalid or missing</response>
        /// <response code="500">If there was an internal error while creating the category</response>
        // POST: api/Categories
        [HttpPost]
        public async Task<ActionResult<Categories>> PostCategories(Categories category)
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
