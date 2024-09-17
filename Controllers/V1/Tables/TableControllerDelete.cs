using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdminV2.Controllers
{
    public partial class TablesController : ControllerBase
    {
        // DELETE: api/tables/5
        [HttpDelete("{id}")]
        [SwaggerOperation(
            Summary = "Delete a table by ID",
            Description = "Deletes a specific table identified by its ID from the database. Returns 404 if the table with the specified ID is not found."
        )]
        
        [SwaggerResponse(204, "The table was successfully deleted.")]
        [SwaggerResponse(404, "If the table with the specified ID is not found.")]
        [SwaggerResponse(500, "If there is an internal server error.")]
        public async Task<IActionResult> DeleteTables(int id)
        {
            var table = await _context.Tables.FindAsync(id);
            if (table == null)
            {
                return NotFound();
            }

            _context.Tables.Remove(table);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
