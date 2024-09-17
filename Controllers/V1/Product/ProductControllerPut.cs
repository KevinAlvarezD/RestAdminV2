using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdminV2.Controllers
{
    public partial class ProductController : ControllerBase
    {
        // PUT: api/products/5
        [HttpPut("{id}")]
        [SwaggerOperation(
            Summary = "Update an existing product",
            Description = "Updates the details of an existing product identified by its ID. Returns 400 if there is a mismatch between the ID in the URL and the ID in the body, or if the input data is invalid. Returns 404 if the product is not found. Returns 500 if there is an internal server error."
        )]
        [SwaggerResponse(204, "The product was successfully updated.")]
        [SwaggerResponse(400, "If there is a mismatch between the ID in the URL and the ID in the body, or if the input data is invalid.")]
        [SwaggerResponse(404, "If the product with the specified ID is not found.")]
        [SwaggerResponse(500, "If there is an internal server error.")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] Product product)
        {
            if (id != product.Id)
            {
                return BadRequest("Product ID mismatch.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
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

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
