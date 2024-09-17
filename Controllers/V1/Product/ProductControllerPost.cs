using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdminV2.Controllers
{
    public partial class ProductController : ControllerBase
    {
        // POST: api/product
        [HttpPost]
        [SwaggerOperation(
            Summary = "Create a new product",
            Description = "Adds a new product to the database. Returns the created product along with its ID. Returns 400 if the input data is invalid."
        )]
        
        [SwaggerResponse(201, "The product was successfully created.")]
        [SwaggerResponse(400, "If the input data is invalid.")]
        [SwaggerResponse(500, "If there was an internal error while creating the product.")]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }
    }
}
