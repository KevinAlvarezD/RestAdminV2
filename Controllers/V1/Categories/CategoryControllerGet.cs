using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;
namespace RestAdmin.Controllers
{
    public partial class CategoriesController
    {
        /// <summary>
        /// Return a list of all categories.
        /// </summary>

        /// <remarks>
        /// This endpoint returns a list of all categories available in the database.
        /// </remarks>

        /// <response code="200">Returns the list of categories</response>
        /// <response code="500">If there was an internal error while fetching the categories</response>

        // GET: api/Categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categories>>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }

        /// <summary>
        /// Return a category by its ID.
        /// </summary>

        /// <param name="id">
        /// The id of the category to Return
        /// </param>

        /// <remarks>
        /// This endpoint allows you to fetch a specific category by providing its ID.
        /// If the category does not exist, a 404 (Not Found) status code is returned.
        /// </remarks>

        /// <response code="200">Returns the requested category</response>
        /// <response code="404">If the category with the specified ID is not found</response>
        /// <response code="500">If there was an internal error while fetching the category</response>

        //Get: api/Categories/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Categories>> GetCategories(int id)
        {
            var Categories = await _context.Categories.FindAsync(id);
            if (Categories == null)
            {
                return NotFound();
            }
            return Categories;
        }
    }
}

