using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdmin.Controllers
{
    public partial class CategoriesController : ControllerBase
    {
        [HttpGet]
        [SwaggerOperation(
            Summary = "Retrieves all categories",
            Description = "Gets a list of all categories in the database."
        )]

        [SwaggerResponse(200, "Returns a list of categories.", typeof(IEnumerable<Categories>))]
        [SwaggerResponse(500, "An internal server error occurred.")]
        public async Task<ActionResult<IEnumerable<Categories>>> GetCategories()
        {
            return await _context.Categories.ToListAsync();
        }

         // GET: api/Categories
        [HttpGet("{id}")]
        [SwaggerOperation(
            Summary = "Retrieves a category by ID",
            Description = "Gets a specific category by providing its ID."
        )]
        
        [SwaggerResponse(200, "Returns the requested category.", typeof(Categories))]
        [SwaggerResponse(404, "If the category with the specified ID is not found.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
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

