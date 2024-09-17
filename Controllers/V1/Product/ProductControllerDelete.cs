using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdminV2.Controllers
{
    public partial class ProductController : ControllerBase
    {
        // DELETE: api/product/5
        [HttpDelete("{id}")]
        [SwaggerOperation(
            Summary = "Deletes a product by ID",
            Description = "Deletes a specific product from the database by its ID. Returns 404 if the product does not exist."
        )]
        
        [SwaggerResponse(204, "The product was successfully deleted.")]
        [SwaggerResponse(404, "If the product with the specified ID is not found.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
