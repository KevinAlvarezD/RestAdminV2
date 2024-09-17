using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.DTOs;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdminV2.Controllers
{
    public partial class ProductController : ControllerBase
    {
        // GET: api/product
        [HttpGet]
        [SwaggerOperation(
            Summary = "Return a list of all products",
            Description = "Returns a list of all products available in the database, including their associated categories."
        )]
        [SwaggerResponse(200, "Returns the list of products.")]
        [SwaggerResponse(500, "If there was an internal error while fetching the products.")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProduct()
        {
            var products = await _context.Products.Include(p => p.Category).ToListAsync();
            return Ok(products);
        }

        // GET: api/product/5
        [HttpGet("{id}")]
        [SwaggerOperation(
            Summary = "Return a product by ID",
            Description = "Returns a specific product from the database by its ID, including its associated category. Returns 404 if the product does not exist."
        )]
        
        [SwaggerResponse(200, "Returns the product with the specified ID.")]
        [SwaggerResponse(404, "If the product with the specified ID is not found.")]
        [SwaggerResponse(500, "If there was an internal error while fetching the product.")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products.Include(p => p.Category).FirstOrDefaultAsync(i => i.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
    }
}
