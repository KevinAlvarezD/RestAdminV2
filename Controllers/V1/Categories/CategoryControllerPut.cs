using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdmin.Controllers
{
    public partial class CategoriesController
    {
        /// <summary>
        /// Updates an existing category by its ID.
        /// </summary>
        
        /// <remarks>
        /// This endpoint allows you to update an existing category in the database. If the category with the specified ID does not exist, a 404 (Not Found) status code is returned. If the request data is invalid or does not match the ID, a 400 (Bad Request) status code is returned.
        /// </remarks>
        
        /// <param name="id">
        /// The ID of the category to update.
        /// </param>
        
        /// <param name="category">
        /// The category object containing the updated data.
        /// </param>
        
        /// <response code="204">If the category was updated successfully</response>
        /// <response code="400">If the category ID does not match or the request data is invalid</response>
        /// <response code="404">If the category with the specified ID was not found</response>
        /// <response code="500">If there was an internal error while updating the category</response>
        
        // PUT: api/Categories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategories(int id, Categories category)
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
